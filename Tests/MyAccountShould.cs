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
        BasePage.InitBrowser();
        _homePage = new HomePage();
        _myAccountPage = _homePage.OpenMyAccount();
        _registerPage = _myAccountPage.SelectRegisterLink();
        _registerPage.Register();

    }


    public void Dispose()
    {

        BasePage.CloseAllBrowsers();
    }
}