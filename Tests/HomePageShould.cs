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
        
        _homePage = new HomePage();
        _homePage.Verify();
    }

    [Fact]
    public void EnsuretheShoppingPriceAndCheckoutPrice()
    {
        _homePage = new HomePage();
        _homePage.SearchAnItemByName("Magic Mouse");
       _homePage.AddItemToCart();       
       
           }

    public void Dispose()
    {

        BasePage.CloseAllBrowsers();
    }

}