using ForthDemo_v1.Interfaces;
using ForthDemo_v1.PageObjects.ClickableObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForthDemo_v1.PageObjects.HeaderObject
{
    public class SearchBar
    {
        private string baseSearchBarCssSelector = "#nav-search";
        private IWebDriver drv;
        private string fullCssSelector;

        public SearchBar(IWebDriver drv, string parentCssSelector)
        {
            this.drv = drv;
            fullCssSelector = $"{parentCssSelector} {baseSearchBarCssSelector}";
        }

       public InputField InputField => new InputField(drv, fullCssSelector, "#twotabsearchtextbox");
       public IClickable SubmitSearchButton => new ClickableObject(drv, fullCssSelector, ".nav-search-submit");
       public IDropDown SearchDropDown => new DropDown(drv,baseSearchBarCssSelector, "#searchDropdownBox");
    }
}
