using ForthDemo_v1.BasePages;
using ForthDemo_v1.PageObjects.HeaderObject;
using OpenQA.Selenium;

namespace ForthDemo_v1.Pages
{
    public class AmazonHomePage : BaseAmazonPage<AmazonHomePage,Header<AmazonHeaderParts>, AmazonHeaderParts>
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
