using OpenQA.Selenium;
using OpenQA.Selenium.Support;

public class HomePage{

  MyAccountPage _myAccountPage ;
    By MyAccountLink = By.CssSelector("a[title='My Account']");

    public MyAccountPage OpenMyAccount()
    {
        Driver._driver.FindElement(MyAccountLink).Click();
        _myAccountPage = new MyAccountPage();
        return _myAccountPage;
    }

}