using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;
using Microsoft.Extensions.Configuration;
using System.IO;
using System;
public class BasePage{

    public static string BaseUrl ; 
    public  IConfiguration _configuration {get;set;}
    public static  IWebDriver _driver;
        public  BasePage()
        {     
            var builder = new ConfigurationBuilder()
                         .AddJsonFile("appsettings.json", optional:true, reloadOnChange:true)
                            .SetBasePath(Directory.GetCurrentDirectory())
                                .AddEnvironmentVariables();

            _configuration = builder.Build();
            BaseUrl=_configuration["BaseURL"];    
        }

       

        public static void InitBrowser()
        {
            //var String = "Chrome";

            ChromeOptions __options = new ChromeOptions();
            __options.AddArgument("--start-maximized");
           _driver = new ChromeDriver(Directory.GetCurrentDirectory()+"/Driver/",__options);           
           _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
           _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
           _driver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(10);
           _driver.Navigate().GoToUrl(BaseUrl);
            
        }

        public static IWebDriver Driver
        {
            get
            {
                if(_driver == null)
                    throw new NullReferenceException("The WebDriver browser instance was not initialized. You should first call the method InitBrowser.");
                    return _driver;
            }
            private set
            {
                _driver = value;
            }
        }
        public static void CloseAllBrowsers()
        {
            _driver.Quit();
        }

  
}