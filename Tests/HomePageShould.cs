using OpenQA.Selenium;
using  OpenQA.Selenium.Chrome;
using Xunit;
using System.IO;
using System;
//[Collection("Our Test Collection #1")]
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
     
}

public void Dispose()
    {
        
        Driver._driver.Close();
    }

}