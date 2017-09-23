using ForthDemo_v1.Enums;
using ForthDemo_v1.Extensions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForthDemo_v1.PageObjects.HeaderObject
{
    public class NavigationFlyoutSuggestions
    {
        private readonly string baseNavigationFlyoutSelector;
        private string fullCssSelector;
        private IWebDriver drv;
        IWebElement element;

        public NavigationFlyoutSuggestions(IWebDriver drv, string parentCssSelector)
        {
            this.baseNavigationFlyoutSelector = "#nav-flyout-searchAjax";
            this.fullCssSelector = $"{parentCssSelector} {baseNavigationFlyoutSelector}";
            this.drv = drv;
        }
        //Todo Need logic improvment for partial text matching of searcBarText to suggestion items text
        //For now its working only for searchBarText + in + Department format
        public void SelectItemByDepartment(string searchBarText, Departments departments)
        {            
            IReadOnlyCollection<IWebElement> suggestions = drv.FindElements(By.CssSelector($"{fullCssSelector} .s-suggestion"));
            IWebElement rowWithSugg = suggestions.First(suggestion => suggestion.Text.ContainsCaseSensitive($"{searchBarText} in {Enum.GetName(typeof(Departments), departments)}",StringComparison.OrdinalIgnoreCase));
            
            rowWithSugg.Click();
        }        
        
    }
}
