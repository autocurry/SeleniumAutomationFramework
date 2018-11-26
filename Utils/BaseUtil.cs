using OpenQA.Selenium;
using  OpenQA.Selenium.Chrome;
using System.IO;
using System;
public class BaseUtil
{

    public bool WaitForElementDisplayed(By element)
    {
        var elementdisplayed = false;
        Int64 i = 0;

        try{
            bool dspl = Driver._driver.FindElement(element).Displayed;
          
        }
        catch(Exception e)
        {

        }


        return elementdisplayed;
    }
}