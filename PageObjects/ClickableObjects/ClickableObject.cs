using ForthDemo_v1.Interfaces;
using OpenQA.Selenium;
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
        private readonly string baseClickableObjectSelector;
        private string fullCssSelector;
        private IWebElement element;

        public ClickableObject(IWebDriver drv,string parentCssSelector,string concreateClicakbleObjectSelector)
        {
            this.drv = drv;
            this.baseClickableObjectSelector = concreateClicakbleObjectSelector;
            this.fullCssSelector = $"{parentCssSelector} {baseClickableObjectSelector}";

            element = drv.FindElement(By.CssSelector(fullCssSelector));
        }

        public void Click()
        {
            element.Click();
        }
    }
}
