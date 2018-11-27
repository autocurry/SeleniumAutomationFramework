using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using System;

public class RegisterPage:BaseUtil{

By _userName = By.XPath("//*[@id='user_login']");
By _email = By.XPath("//*[@id='user_email']");
By _registerButton = By.XPath("//*[@id='wp-submit']");

public void Register()
{
    Type(_userName,"testing"+new Random().Next().ToString());
    Type(_email,"test.test@gmail.com");
    SingleClick(_registerButton);


}


}