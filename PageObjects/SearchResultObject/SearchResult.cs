using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForthDemo_v1.PageObjects.SearchResultObject
{
    public class SearchResult<TItemDetailsRow>
        where TItemDetailsRow : ItemDetailRow
    {
        private IWebDriver drv;
        public SearchResult(IWebDriver drv)
        {
            this.drv = drv;
        }
        public TItemDetailsRow GetDetailRow(int rowIndex)
        {
            return (TItemDetailsRow)Activator.CreateInstance(typeof(TItemDetailsRow), drv, rowIndex);
        }
    }
}
