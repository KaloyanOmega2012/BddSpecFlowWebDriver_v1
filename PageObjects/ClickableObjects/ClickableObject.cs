using ForthDemo_v1.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForthDemo_v1.PageObjects.ClickableObjects
{
    public class ClickableObject : IClickable
    {
        private IWebDriver drv;
        private readonly string concreateClicakbleObjectSelector;
        private string fullCssSelector;
        private IWebElement element;

        public string Text => element.Text;

        public ClickableObject(IWebDriver drv,string parentCssSelector,string concreateClicakbleObjectSelector)
        {
            this.drv = drv;
            this.concreateClicakbleObjectSelector = concreateClicakbleObjectSelector;
            this.fullCssSelector = $"{parentCssSelector} {concreateClicakbleObjectSelector}";
            var elements = drv.FindElements(By.CssSelector(fullCssSelector));
            WebDriverWait waitForClickableState = new WebDriverWait(drv, TimeSpan.FromSeconds(Settings.Default.ShortWaitInSeconds));
            element = waitForClickableState.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(fullCssSelector)));
        }

        public void Click()
        {
            element.Click();
        }

        
    }
}
