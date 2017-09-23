using ForthDemo_v1.Enums;
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
        public void Debug()
        {
            var searchedItemText = "Harry Potter and the cursed child";

            IWebDriver drv = new ChromeDriver();
            drv.Manage().Window.Maximize();

            var amazonHomePage = new AmazonHomePage(drv);
            amazonHomePage.NavigateTo();
            amazonHomePage.IsAt();
            amazonHomePage.Header.GetHeaderParts.SearchBar.InputField.Text = searchedItemText;
            amazonHomePage.Header.GetHeaderParts.NavigationFlyoutSearch.SelectItemByDepartment(searchedItemText, Departments.Books);
            
            
        }

    }
}
