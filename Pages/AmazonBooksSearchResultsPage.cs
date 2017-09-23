using ForthDemo_v1.BasePages;
using ForthDemo_v1.PageObjects.HeaderObject;
using ForthDemo_v1.PageObjects.SearchResultObject;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForthDemo_v1.Pages
{
    class AmazonBooksSearchResultsPage : BaseAmazonPage<AmazonHomePage, Header<AmazonHeaderParts>, AmazonHeaderParts>
    {
        public AmazonBooksSearchResultsPage(IWebDriver drv)
        {
            base.drv = drv;
        }

        //specific objects
        public SearchResult<ItemDetailRow> SearchResults => new SearchResult<ItemDetailRow>(drv);
        
        public override string PageUrl => "https://www.amazon.co.uk/s/";
    }
}
