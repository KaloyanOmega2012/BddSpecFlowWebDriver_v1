using ForthDemo_v1.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForthDemo_v1
{
    [TestFixture]
    class WebDrvTests
    {
        [Test]
        public void Debug()
        {
            var amazonHomePage = new AmazonHomePage(new ChromeDriver());
            amazonHomePage.NavigateTo();
         //   amazonHomePage.Header.SearchBar.
            amazonHomePage.IsAt();
        }

    }
}
