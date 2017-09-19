using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForthDemo_v1.Pages
{
    //base page that hold high level common code for a webPage
    public abstract class BasePage<TPage> where TPage : BasePage<TPage>
    {
        protected  IWebDriver drv;

        public bool IsAt()
        {
            return drv.Url.Equals(PageUrl);
        }

        public void NavigateTo()
        {
            TPage page = (TPage)Activator.CreateInstance(typeof(TPage),drv);
            drv.Url = page.PageUrl;
        }

        public abstract string PageUrl { get; }
    }
}
