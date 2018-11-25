using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;
using Microsoft.Extensions.Configuration;
using System.IO;
using System;
public class BasePage{

    public string BaseUrl { get; set; }
    public  IConfiguration _configuration {get;set;}
        IWebDriver _driver;
        public  BasePage()
        {     
            
         var builder = new ConfigurationBuilder()
                         .AddJsonFile("appsettings.json", optional:true, reloadOnChange:true)
                            .SetBasePath(Directory.GetCurrentDirectory())
                                .AddEnvironmentVariables();

            _configuration = builder.Build();

            BaseUrl = _configuration["BaseUrl"];
            LaunchBrowser();
      
        }

        public void LaunchBrowser()
        {
            ChromeOptions __options = new ChromeOptions();
            __options.AddArgument("--start-maximized");
           _driver = new ChromeDriver(Directory.GetCurrentDirectory()+"/Driver/",__options);
           Driver._driver = _driver;
           Driver._driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
           Driver._driver.Navigate().GoToUrl(BaseUrl);
            
        }

  
}