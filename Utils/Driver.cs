using OpenQA.Selenium;

public  class Driver:BasePage{

private browserType = config["browser"];
private IWebDriver _driver;
public IWebDriver MyProperty
{
    get { 
        if(_driver == null)
        {
            _driver = CreateNewDriverInstance(string browserType);
        }
        return _driver;
        }
    set { _driver = value;}
}

private void CreateNewDriverInstance()
{


}


}