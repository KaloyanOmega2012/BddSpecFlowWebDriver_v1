using OpenQA.Selenium;


namespace ForthDemo_v1.PageObjects.HeaderObject
{
     public abstract class HeaderPart
    {
        protected IWebDriver drv;

        public HeaderPart(IWebDriver drv)
        {
            this.drv = drv;
        }
    }
}
