using ForthDemo_v1.Enums;
using ForthDemo_v1.PageObjects;
using ForthDemo_v1.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace ForthDemo_v1
{
    [TestFixture]
    class WebDrvTests
    {
        [Test]
        public void SelectItem()
        {
            var searchedItemText = "It: film tie-in edition of Stephen King’s IT";

            IWebDriver drv = new ChromeDriver();
            drv.Manage().Window.Maximize();

            var amazonHomePage = new AmazonHomePage(drv);
            amazonHomePage.NavigateTo();
            amazonHomePage.IsAt();
            amazonHomePage.Header.GetHeaderParts.SearchBar.SearchDropDown.SelectItemByName("Books");
            amazonHomePage.Header.GetHeaderParts.SearchBar.InputField.Text = searchedItemText;
            amazonHomePage.Header.GetHeaderParts.SearchBar.SubmitSearchButton.Click();
            var amazonBooksSearchResultsPage = new AmazonBooksSearchResultsPage(drv);
            var titleText = amazonBooksSearchResultsPage.SearchResults.GetDetailRow(0).Title.Text;

            var fisrSelectedTypeText = amazonBooksSearchResultsPage.SearchResults.GetDetailRow(2).FirstSelectedType.Text;
            var fistSelectedTypePrice = amazonBooksSearchResultsPage.SearchResults.GetDetailRow(2).FirstSelectedTypePrice.Text;

        }

        [Test]
        public void Debug()
        {
            IWebDriver drv = new ChromeDriver();
            drv.Manage().Window.Maximize();

            var amazonHomePage = new AmazonHomePage(drv);
            amazonHomePage.NavigateTo();
            var drp = new DropDown(drv,"", "#searchDropdownBox");
            drp.SelectItemByName("Pet Supplies");
        }

    }
}
