using OpenQA.Selenium;
using OpenQA.Selenium.Support;

public class BasePage{
    IWebDriver _driver;
  

    public void Set(By _element,string _value)
{
    _driver.FindElement(_element).SendKeys("test.test@gmail.com");

}
}