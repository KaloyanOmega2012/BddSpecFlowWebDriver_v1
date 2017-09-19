using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForthDemo_v1.PageObjects
{
    public class InputField
    {
        private IWebDriver drv;
        private readonly string cssSelector = "input";
        private IWebElement element;
        
        public InputField(IWebDriver drv,string parentSelector)
        {
            this.drv = drv;
            string fullSelector = $"{parentSelector} {cssSelector}";
            element = drv.FindElement(By.CssSelector(fullSelector));
        }

        public string Text
        {
            get
            {
               return element.GetAttribute("value");
            }
            set
            {
                element.Clear();
                element.SendKeys(value);
            }
        }


    }
}
