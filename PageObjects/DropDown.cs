using ForthDemo_v1.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ForthDemo_v1.PageObjects
{
    class DropDown : IDropDown
    {
        private readonly string baseDropDownLocator = "select";
        private string parentCssLocator;
        private string fullCssLocator;
        private IWebDriver drv;
        private SelectElement drpDown;

        public DropDown(IWebDriver drv, string parentCssLocator, string concreteCssLocator)
        {
            this.drv = drv;
            this.parentCssLocator = parentCssLocator;

            fullCssLocator = $"{parentCssLocator} {baseDropDownLocator}{concreteCssLocator}";
        }
        public void SelectItemByName(string itemName)
        {
            drpDown = new SelectElement(drv.FindElement(By.CssSelector($"{fullCssLocator}")));
            drpDown.SelectByText(itemName);
        }
    }
}
