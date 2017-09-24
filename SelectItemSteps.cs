using ForthDemo_v1.Helpers;
using ForthDemo_v1.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Globalization;
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
        //ToDo make Bdd steps reusable with parameters for e.g. 
        private Context context;
        public SelectItemSteps()
        {
            this.context = new Context();
            context.drv.Manage().Window.Maximize();
        }

        [Given(@"I am on amazon home page")]
        public void GivenIAmOnAmazonHomePage()
        {            
            context.amazonHomePage.NavigateTo();
            var expectedPage = context.amazonHomePage.IsAt();
            Assert.IsTrue(expectedPage, "We are not on the AmazonHomePage");
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
            var expectedItemName = context.itemName;
            var actualItemName = context.amazonBooksSearchResultsPage.SearchResults.GetDetailRow(0).Title.Text;

            Assert.AreEqual(expectedItemName,actualItemName);
        }


        [Then(@"it should be on first position inside items collection")]
        public void ThenItShouldBeOnFirstPositionInsideItemsCollection()
        {
            //we are using zero based index
            var expectedItemPosition = 0;
            var actualItemPosition = context.amazonBooksSearchResultsPage.SearchResults.GetDetailRow(0).ItemPosition;

            Assert.AreEqual(expectedItemPosition,actualItemPosition);
        }

        [Then(@"It has a badge “Best Seller”")]
        public void ThenItHasABadgeBestSeller()
        {
            var expectedBadgeText = "Best Seller";
            var actulaBadgeText = context.amazonBooksSearchResultsPage.SearchResults.GetDetailRow(0).Badge.Text;

            Assert.AreEqual(expectedBadgeText,actulaBadgeText);
        }

        [Then(@"Selected type is Paperback")]
        public void ThenSelectedTypeIsPaperback()
        {
            var expectedFirstType = "Paperback";
            var actualFirstType = context.amazonBooksSearchResultsPage.SearchResults.GetDetailRow(0).FirstSelectedType.Text;

            Assert.AreEqual(expectedFirstType, actualFirstType);
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
