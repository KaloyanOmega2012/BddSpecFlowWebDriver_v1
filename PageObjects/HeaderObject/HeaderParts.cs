using ForthDemo_v1.Interfaces;
using OpenQA.Selenium;

namespace ForthDemo_v1.PageObjects.HeaderObject
{
    //contains common for all pages header parts
     public abstract class HeaderParts
    {
        protected IWebDriver drv;
        protected string baseHeaderSelector;
        
        protected HeaderParts(IWebDriver drv, string baseHeaderSelector)
        {
            this.drv = drv;
            this.baseHeaderSelector = baseHeaderSelector;
        }

        public SearchBar SearchBar => new SearchBar(drv, baseHeaderSelector);
        public NavigationFlyoutSuggestions NavigationFlyoutSearch => new NavigationFlyoutSuggestions(drv, baseHeaderSelector);
        
    }
}
