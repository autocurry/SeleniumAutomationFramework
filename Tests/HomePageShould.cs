using OpenQA.Selenium;
using  OpenQA.Selenium.Chrome;
using Xunit;
using System.IO;
using System;

public class HomePageShould:BasePage,IDisposable{

HomePage _homePage;


public HomePageShould():base()
    {
        

    } 

[Fact]

public void LoadCorrectly()
{
    _homePage = new HomePage();
     _homePage.Verify();
}

[Fact]
[Trait("name","checkout")]
public void EnsuretheShoppingPriceAndCheckoutPrice()
{
     _homePage = new HomePage();
     _homePage.SearchAnItemByName("Magic Mouse");
      Assert.True(_homePage.AddItemToCart());
      

     

     
}

public void Dispose()
    {
        
        Driver._driver.Quit();
    }

}