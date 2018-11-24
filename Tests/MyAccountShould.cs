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
       _myAccountPage =_homePage.OpenMyAccount();
        _registerPage = _myAccountPage._clickRegisterLink();
       _registerPage.Register();
        Assert.True(true);
    }
    

    public void Dispose()
    {
        Driver._driver.Quit();
    }
}