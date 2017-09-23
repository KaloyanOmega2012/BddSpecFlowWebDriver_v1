using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForthDemo_v1.PageObjects.HeaderObject
{
    public class AmazonHeaderParts : HeaderParts
    {

        public AmazonHeaderParts(IWebDriver drv, string baseHeaderSelector):base(drv,baseHeaderSelector)
        {
                
        }        
    }
}
