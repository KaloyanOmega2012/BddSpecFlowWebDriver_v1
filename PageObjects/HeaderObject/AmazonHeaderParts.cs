using OpenQA.Selenium;

namespace ForthDemo_v1.PageObjects.HeaderObject
{
    public class AmazonHeaderParts : HeaderParts
    {

        public AmazonHeaderParts(IWebDriver drv, string baseHeaderSelector):base(drv,baseHeaderSelector)
        {
                
        }        
    }
}
