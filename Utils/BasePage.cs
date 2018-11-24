using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using Microsoft.Extensions.Configuration;
using System.IO;
public class BasePage{

    public string BaseUrl { get; set; }
    public  IConfiguration _configuration {get;set;}
        public  BasePage()
        {
     
         var builder = new ConfigurationBuilder()
                         .AddJsonFile("appsettings.json", optional:true, reloadOnChange:true)
                            .SetBasePath(Directory.GetCurrentDirectory())
                                .AddEnvironmentVariables();

            _configuration = builder.Build();

            BaseUrl = _configuration["BaseUrl"];
      
        }
  
}