using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;

public class MyAccountShould : BasePage, IDisposable
{

    HomePage _homePage;
    MyAccountPage _myAccountPage;
    RegisterPage _registerPage;
    public MyAccountShould() : base()
    {

        BasePage.InitBrowser();
    }

    [Fact]
    public void RegisterANewUser()
    {
       
         Page.Home.OpenMyAccount();
         Page.MyAccount.SelectRegisterLink();
         Page.Register.Register();

    }


    public void Dispose()
    {

        BasePage.CloseAllBrowsers();
    }
}