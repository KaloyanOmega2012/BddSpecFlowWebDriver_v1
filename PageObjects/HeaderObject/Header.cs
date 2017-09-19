using ForthDemo_v1.PageObjects.HeaderObject;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForthDemo_v1.PageObjects
{
    public abstract class Header<THeaderParts> 
        where THeaderParts:HeaderPart

    {
        protected readonly string baseHeaderCssSelector = "header.nav-locale-gb";
        protected IWebDriver drv;
        public Header(IWebDriver drv)
        {
            this.drv = drv;    
        }

        //child objects
        public SearchBar SearchBar => (SearchBar)Activator.CreateInstance(typeof(SearchBar),drv, baseHeaderCssSelector);
    }
}
