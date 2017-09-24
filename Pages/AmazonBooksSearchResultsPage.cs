using ForthDemo_v1.BasePages;
using ForthDemo_v1.PageObjects.HeaderObject;
using ForthDemo_v1.PageObjects.SearchResultObject;
using OpenQA.Selenium;

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

        //ToDo - to make some logic that check if the page url contains 
        //"Settings.BaseUrl" + "url=search-alias%3Dstripbooks" parameter
        //in order to verify that I am on the page
        public override string PageUrl => "https://www.amazon.co.uk/s/";
    }
}
