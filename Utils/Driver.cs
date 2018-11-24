using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public static class Driver{

public static IWebDriver _driver{
    get
    {
        if(_driver == null)
        {
            _driver = new ChromeDriver("Driver/chromedriver");
        }
        return _driver;
    }
    set
    {
       
        
    }
}



}