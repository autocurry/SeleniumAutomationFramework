using Xunit;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class TestRunner : IDisposable
{
    IWebDriver _driver;
    public TestRunner ()
    {
        Console.WriteLine("inside the setup");
        _driver= new ChromeDriver("/home/sandeep/Desktop/SeleniumAutomation/SeleniumAutomationFramework/SeleniumAutomationProject/Driver");
       
    }

    public void Dispose()
    {
        Console.Write("inside the teardown");
    }

    [Fact]
    public void FirstTest()
    {
    
    Console.WriteLine("inside the first test");
    _driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
    
    }
}

