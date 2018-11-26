using OpenQA.Selenium;
using  OpenQA.Selenium.Chrome;
using Xunit;
using System.IO;
using System;
public class HomePageShould:BasePage,IDisposable{

HomePage _homePage;
IWebDriver _driver ;

public HomePageShould():base()
    {
        

    } 

[Fact]
public void LoadCorrectly()
{
    _homePage = new HomePage();
     _homePage.Verify();
}

public void Dispose()
    {
        Driver._driver.Quit();
    }

}