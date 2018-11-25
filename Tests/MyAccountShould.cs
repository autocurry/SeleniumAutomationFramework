using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;


public class MyAccountShould:BasePage,IDisposable{

   HomePage _homePage;
   MyAccountPage _myAccountPage;
   RegisterPage _registerPage;
    public MyAccountShould():base()
    {
        

    }    

    [Fact]
    public void RegisterANewUser()
    {    
        _homePage = new HomePage();
       _myAccountPage =_homePage.OpenMyAccount();
        _registerPage = _myAccountPage._clickRegisterLink();
      var result = _registerPage.Register();
        Assert.True(result);
    }
    

    public void Dispose()
    {
        Driver._driver.Quit();
    }
}