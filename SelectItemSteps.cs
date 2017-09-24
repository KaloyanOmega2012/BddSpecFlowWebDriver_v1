using ForthDemo_v1.Helpers;
using ForthDemo_v1.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace ForthDemo_v1
{
    class Context
    {
        internal IWebDriver drv;

        internal AmazonHomePage amazonHomePage;
        internal AmazonBooksSearchResultsPage amazonBooksSearchResultsPage;
        internal readonly string itemName = "It: film tie-in edition of Stephen King’s IT";
        internal CurrencyConvertor currencyConvertor;

        internal Context()
        {
            drv = new ChromeDriver();
            amazonHomePage = new AmazonHomePage(drv);
            amazonBooksSearchResultsPage = new AmazonBooksSearchResultsPage(drv);
        }
    }

    [Binding]
    class SelectItemSteps
    {
        private Context context;
        public SelectItemSteps()
        {
            this.context = new Context();
        }

        [Given(@"I am on amazon home page")]
        public void GivenIAmOnAmazonHomePage()
        {            
            context.amazonHomePage.NavigateTo();
            Assert.IsTrue(context.amazonHomePage.IsAt(), "We are not on the AmazonHomePage");
        }

        [Given(@"I have entered item name inside searchbar")]
        public void GivenIHaveEnteredItemNameInsideSearcbar()
        {            
            
            context.amazonHomePage.Header.GetHeaderParts.SearchBar.SearchDropDown.SelectItemByName("Books");
            context.amazonHomePage.Header.GetHeaderParts.SearchBar.InputField.Text = context.itemName;

        }

        [When(@"I press search button inside searchbar")]
        public void WhenIPressSearchButtonInsideSearchbar()
        {
            context.amazonHomePage.Header.GetHeaderParts.SearchBar.SubmitSearchButton.Click();
        }

        [Then(@"then the item is found")]
        public void ThenThenTheItemIsFound()
        {
            //Verify title of the searched item
            Assert.AreEqual(context.itemName, context.amazonBooksSearchResultsPage.SearchResults.GetDetailRow(0).Title.Text);
        }


        [Then(@"it should be on first position inside items collection")]
        public void ThenItShouldBeOnFirstPositionInsideItemsCollection()
        {
            Assert.AreEqual(0,context.amazonBooksSearchResultsPage.SearchResults.GetDetailRow(0).ItemPosition);
        }

        [Then(@"It has a badge “Best Seller”")]
        public void ThenItHasABadgeBestSeller()
        {
            Assert.AreEqual("Best Seller", context.amazonBooksSearchResultsPage.SearchResults.GetDetailRow(0).Badge.Text);
        }

        [Then(@"Selected type is Paperback")]
        public void ThenSelectedTypeIsPaperback()
        {
            Assert.AreEqual("Paperback", context.amazonBooksSearchResultsPage.SearchResults.GetDetailRow(0).FirstSelectedType.Text);
        }

        [Then(@"And the price is (.*)")]
        public void ThenAndThePriceIs(string p0)
        {
            context.currencyConvertor = new CurrencyConvertor(NumberStyles.Number | NumberStyles.AllowCurrencySymbol, CultureInfo.CreateSpecificCulture("en-GB"));

            var expectedPrice = context.currencyConvertor.ConvertCurrencyStringToDecimal(p0);
            var actualPrice = context.currencyConvertor.ConvertCurrencyStringToDecimal(context.amazonBooksSearchResultsPage.SearchResults.GetDetailRow(0)
                                                                                        .FirstSelectedTypePrice.Text);
            Assert.AreEqual(expectedPrice,actualPrice);
        }




    }
}
