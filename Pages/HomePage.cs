using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using System.Collections.Generic;

public class HomePage{

  MyAccountPage _myAccountPage ;
    By MyAccountLink = By.CssSelector("a[title='My Account']");
    By HomeMenu = By.LinkText("Home");
    By SearchBox = By.CssSelector("input[value='Search Products']");
    By CartItemCount = By.CssSelector(".count");
    By ItemMagicMouse = By.CssSelector("a[href*='magic-mouse']");
    By CurrentPrice = By.CssSelector(".currentprice");
    By AddToCartButton = By.CssSelector("input[value='Add To Cart']");
    By LoadingImage = By.CssSelector("img[alt='loading']");



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

    public void SearchAnItemByName(string name)
    {
        Driver._driver.FindElement(SearchBox).SendKeys(name+Keys.Return);
        WaitForElementDisplayed(ItemMagicMouse);

    }

}