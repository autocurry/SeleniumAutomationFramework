using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;


public class MyAccountShould:BasePage,IDisposable{

   
    public MyAccountShould():base()
    {
        

    }
    HomePage _homePage = new HomePage();

    [Fact]
    public void SendAValidMessage()
    {    
       var result =_homePage.OpenMyAccount();
       
        Assert.True(result);
    }
    

    public void Dispose()
    {
        Driver._driver.Quit();
    }
}