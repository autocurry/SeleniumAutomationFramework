using OpenQA.Selenium;
using  OpenQA.Selenium.Chrome;
using System.IO;
using System;
using OpenQA.Selenium.Support.UI;
public class BaseUtil
{
    int timeoutInSeconds = 20;

    public IWebElement WaitForElementDisplayed(By by)
    {         
         var wait = new WebDriverWait(Driver._driver, TimeSpan.FromSeconds(timeoutInSeconds));
         return wait.Until(drv => drv.FindElement(by));
    }

    public string GetText(By by)
    {         
         IWebElement element = WaitForElementDisplayed(by);
         return element?.Text;
    }

    public void TypeAndReturn(By by,string text)
    {         
         IWebElement element = WaitForElementDisplayed(by);
         element.SendKeys(text+Keys.Return);
    }

    public void Type(By by,string text)
    {         
         IWebElement element = WaitForElementDisplayed(by);
         element.SendKeys(text);
    }

    public void SingleClick(By by)
    {         
         IWebElement element = WaitForElementDisplayed(by);
         element?.Click();
    }

  

     public void CheckItemExists(string itemname)
    {         
        
    }

}