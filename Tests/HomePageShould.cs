using OpenQA.Selenium;
using  OpenQA.Selenium.Chrome;
using Xunit;
using System.IO;
public class HomePageShould{

IWebDriver _driver ;

[Fact]
public void LoadCorrectly()
{
    var path = Directory.GetCurrentDirectory();
     _driver = new ChromeDriver(path+"/Driver/");
     _driver.Navigate().GoToUrl("https://www.google.com.sg/");
     _driver.Quit();
}



}