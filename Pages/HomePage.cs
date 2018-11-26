using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using System.Collections.Generic;

public class HomePage{

  MyAccountPage _myAccountPage ;
    By MyAccountLink = By.CssSelector("a[title='My Account']");
    By HomeMenu = By.LinkText("Home");
  


    public MyAccountPage OpenMyAccount()
    {
        Driver._driver.FindElement(MyAccountLink).Click();
        _myAccountPage = new MyAccountPage();
        return _myAccountPage;
    }

    public void Verify()
    {        
        Driver._driver.FindElement(HomeMenu).Click();
       
    }

}