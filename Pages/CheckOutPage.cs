using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using System.Collections.Generic;

public class CheckOutPage{

By DisplayedItemPrice = By.CssSelector(".pricedisplay");
By ItemMagicMouse = By.CssSelector("a[href*='magic-mouse']");

//Verfies the price is same for the item displayed while adding to cart and price during checkout
public bool VerifyItemPrice(string expectedprice)
{
    var result = false;
    var displayedprice = Driver._driver.FindElement(DisplayedItemPrice).Text;
    if(expectedprice.Equals(displayedprice))
    {
        result=true;
    }
    return result;
}

}