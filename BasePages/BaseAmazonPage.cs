using ForthDemo_v1.PageObjects;
using ForthDemo_v1.PageObjects.HeaderObject;
using ForthDemo_v1.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForthDemo_v1.BasePages
{
    public abstract class BaseAmazonPage<TPage, THeader, THeaderParts> : BasePage<TPage>
        where TPage : BasePage<TPage>
        where THeader : Header<THeaderParts>
        where THeaderParts : HeaderParts
    {
        public Header<AmazonHeaderParts> Header => (Header<AmazonHeaderParts>)Activator.CreateInstance(typeof(Header<AmazonHeaderParts>), drv);

    }
}
