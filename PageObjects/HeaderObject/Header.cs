using OpenQA.Selenium;
using System;

namespace ForthDemo_v1.PageObjects.HeaderObject
{
    public class Header<THeaderParts> 
        where THeaderParts:HeaderParts

    {
        protected readonly string baseHeaderCssSelector = "#navbar";
        protected IWebDriver drv;

        public Header(IWebDriver drv)
        {
            this.drv = drv;    
        }

        //child objects
        public THeaderParts GetHeaderParts => (THeaderParts)Activator.CreateInstance(typeof(THeaderParts),drv, baseHeaderCssSelector);
    }
}
