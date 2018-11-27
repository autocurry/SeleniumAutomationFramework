using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
[Collection("Our Test Collection #1")]
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
        _registerPage = _myAccountPage.SelectRegisterLink();
         _registerPage.Register();
        
    }
    

    public void Dispose()
    {
        
        Driver._driver.Close();
    }
}