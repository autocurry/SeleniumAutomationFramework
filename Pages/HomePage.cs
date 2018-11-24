using OpenQA.Selenium;
using OpenQA.Selenium.Support;

public class HomePage{

  MyAccount _myAccountPage ;
    By MyAccountLink = By.CssSelector("a[title='My Account']");

    public MyAccount OpenMyAccount()
    {
        Driver._driver.FindElement(MyAccountLink).Click();
        _myAccountPage = new MyAccount();
        return _myAccountPage;
    }

}