using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;
using System.IO;
using System;

public class HomePageShould : BasePage, IDisposable
{

    HomePage _homePage;


    public HomePageShould() : base()
    {
        BasePage.InitBrowser();

    }

    [Fact]

    public void LoadCorrectly()
    {
        
        Page.Home.Verify();
        
    }

    [Fact]
    public void EnsuretheShoppingPriceAndCheckoutPrice()
    {
        
        Page.Home.SearchAnItemByName("Magic Mouse");
        Page.Home.AddItemToCart();       
       
           }

    public void Dispose()
    {

        BasePage.CloseAllBrowsers();
    }

}