using ForthDemo_v1;
using ForthDemo_v1.BasePages;
using ForthDemo_v1.PageObjects;
using ForthDemo_v1.PageObjects.HeaderObject;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForthDemo_v1.Pages
{
    public class AmazonHomePage : BaseAmazonPage<AmazonHomePage,Header<SearchBar>,SearchBar>
    {
        //ctor
        public AmazonHomePage(IWebDriver drv)
        {
            base.drv = drv;
        }

        //objects
        public override string PageUrl => Settings.Default.BaseAddress;


    }
}
