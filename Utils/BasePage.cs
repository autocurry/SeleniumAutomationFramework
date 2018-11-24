using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;
using Microsoft.Extensions.Configuration;
using System.IO;
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
           _driver = new ChromeDriver(Directory.GetCurrentDirectory()+"/Driver/");
           Driver._driver = _driver;
           Driver._driver.Navigate().GoToUrl(BaseUrl);
            
        }

  
}