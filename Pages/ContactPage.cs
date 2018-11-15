using OpenQA.Selenium;
using OpenQA.Selenium.Support;

public class ContactPage{
IWebDriver _driver;


By _ContactEmail =  By.CssSelector("input[id='email']");

public IWebElement ContactEmail => _driver.FindElement(_ContactEmail);




}