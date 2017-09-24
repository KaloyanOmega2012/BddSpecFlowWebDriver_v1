using OpenQA.Selenium;

namespace ForthDemo_v1.PageObjects
{
    public class InputField
    {
        private IWebDriver drv;
        private readonly string baseCssSelector = "input";
        private IWebElement element;

        public InputField(IWebDriver drv, string parentSelector, string elementSpecificLocator)
        {
            this.drv = drv;
            string fullSelector = $"{parentSelector} {baseCssSelector}{elementSpecificLocator}";
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
