using ForthDemo_v1.Interfaces;
using ForthDemo_v1.PageObjects.ClickableObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForthDemo_v1.PageObjects.SearchResultObject
{
    public class ItemDetailRow
    {
        //ToDo - Add logic to handle rowIndex=1 because of the author info section

        private readonly string baseSearchResultCssSelector = "#resultsCol #atfResults";
        private int rowIndex;
        private IWebDriver drv;
        

        //rowIndex is zero based
        public ItemDetailRow(IWebDriver drv, int rowIndex)
        {
            this.drv = drv;
            this.rowIndex = rowIndex;
        }

        public int ItemPosition => rowIndex;
        public IClickable Title => new ClickableObject(drv, baseSearchResultCssSelector, $"#result_{rowIndex} h2.s-access-title");
        public IClickable Badge => new ClickableObject(drv, baseSearchResultCssSelector, $"#result_{rowIndex} .a-badge-text");
        public IClickable FirstSelectedType => new ClickableObject(drv, baseSearchResultCssSelector, $"#result_{rowIndex} .a-column.a-span7 >div:nth-of-type(1)");
        public IClickable FirstSelectedTypePrice => new ClickableObject(drv, baseSearchResultCssSelector, $"#result_{rowIndex} .a-column.a-span7 >div:nth-of-type(2)");

    }
}
