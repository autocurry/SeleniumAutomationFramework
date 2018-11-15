using OpenQA.Selenium;
using OpenQA.Selenium.Support;

public class ContactPage : BasePage{
IWebDriver _driver;
public ContactPage:BasePage(_driver){
    
}

By _ContactEmail =  By.CssSelector("input[id='email']");

public IWebElement ContactEmail => _driver.FindElement(_ContactEmail);




}