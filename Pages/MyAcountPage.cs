using OpenQA.Selenium;
using OpenQA.Selenium.Support;

public class MyAccountPage{

RegisterPage _registerPage;
By _RegisterLink =  By.XPath("//*[@id='meta']/ul/li[1]/a");

public RegisterPage _clickRegisterLink()
{
    Driver._driver.FindElement(_RegisterLink).Click();
    _registerPage = new RegisterPage();
    return _registerPage;
}




}