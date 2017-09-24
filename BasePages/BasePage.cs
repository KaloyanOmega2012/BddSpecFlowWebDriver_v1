using OpenQA.Selenium;
using System;

namespace ForthDemo_v1.Pages
{
    //base page that hold high level common code for a webPage including the Browser related actions
    //We can have IWebPage interface above this class but its skiped because of lack of time and need at the moment
    public abstract class BasePage<TPage>
        where TPage : BasePage<TPage>
    {
        protected  IWebDriver drv;

        public bool IsAt()
        {
            return drv.Url.Equals(PageUrl);
        }

        public void NavigateTo()
        {
            TPage page = (TPage)Activator.CreateInstance(typeof(TPage), drv);
            drv.Url = page.PageUrl;
        }

        public abstract string PageUrl { get; }
    }
}
