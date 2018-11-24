using OpenQA.Selenium;
using OpenQA.Selenium.Support;

public class MyAccount{

By _ContactEmail =  By.CssSelector("input[id='email']");

public IWebElement ContactEmail => Driver._driver.FindElement(_ContactEmail);




}