using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForthDemo_v1.PageObjects.HeaderObject
{
    public class HeaderPartForDelete : HeaderPart
    {
        private string baseSearchBarCssSelector = ".nav-search-field ";

        public HeaderPartForDelete(IWebDriver drv):base(drv)
        {
                
        }

        InputField InputField => new InputField(drv, baseSearchBarCssSelector);
    }
}
