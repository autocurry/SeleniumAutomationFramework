using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using System;

public class RegisterPage{

By _userName = By.XPath("//*[@id='user_login']");
By _email = By.XPath("//*[@id='user_email']");
By _registerButton = By.XPath("//*[@id='wp-submit']");

public bool Register()
{
    Driver._driver.FindElement(_userName).SendKeys("testing"+new Random().Next());
    Driver._driver.FindElement(_email).SendKeys("test.test@gmail.com");
    Driver._driver.FindElement(_registerButton).Click();

    return true;
}


}