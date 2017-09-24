using ForthDemo_v1.PageObjects.HeaderObject;
using ForthDemo_v1.Pages;
using System;

namespace ForthDemo_v1.BasePages
{
    //page to hold the code for the base amazon content pages with Header,Footer,LeftNavigationMenu and MiddleResultSections
    //for now only Header and MiddleResult section is partially implemented
    public abstract class BaseAmazonPage<TPage, THeader, THeaderParts> : BasePage<TPage>
        where TPage : BasePage<TPage>
        where THeader : Header<THeaderParts>
        where THeaderParts : HeaderParts
    {
        public Header<AmazonHeaderParts> Header => (Header<AmazonHeaderParts>)Activator.CreateInstance(typeof(Header<AmazonHeaderParts>), drv);

    }
}
