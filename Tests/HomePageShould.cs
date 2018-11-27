using OpenQA.Selenium;
using  OpenQA.Selenium.Chrome;
using Xunit;
using System.IO;
using System;
[Collection("Our Test Collection #1")]
public class HomePageShould:BasePage,IDisposable{

HomePage _homePage;


public HomePageShould():base()
    {
        Console.WriteLine("inside constuctor of home page should");

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
        Console.WriteLine("inside dispose of homepageshould");
        Driver._driver.Close();
    }

}