using OpenQA.Selenium;
using OpenQA.Selenium.Support;

public class MyAccountPage:BaseUtil{

RegisterPage _registerPage;
By _RegisterLink =  By.XPath("//*[@id='meta']/ul/li[1]/a");

public RegisterPage SelectRegisterLink()
{
    SingleClick(_RegisterLink);
    _registerPage = new RegisterPage();
    return _registerPage;
}




}