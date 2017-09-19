using ForthDemo_v1.Pages;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace ForthDemo_v1
{
    [Binding]
    class SelectItemSteps
    {
        [Given(@"I am on amazon home page")]
        public void GivenIAmOnAmazonHomePage()
        {
            var amazonHomePage = new AmazonHomePage(new ChromeDriver());
            amazonHomePage.NavigateTo();
        }

        [Given(@"I have entered item name inside searchbar")]
        public void GivenIHaveEnteredItemNameInsideSearcbar()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I press search button inside searchbar")]
        public void WhenIPressSearchButtonInsideSearchbar()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"then the item should be found")]
        public void ThenThenTheItemShouldBeFound()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"it should be on first position inside items collection")]
        public void ThenItShouldBeOnFirstPositionInsideItemsCollection()
        {
            ScenarioContext.Current.Pending();
        }


    }
}
