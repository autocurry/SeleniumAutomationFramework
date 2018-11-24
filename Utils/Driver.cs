using OpenQA.Selenium;

public  class Driver{

private string browserType;
private IWebDriver _driver;
public IWebDriver MyProperty
{
    get { 
        if(_driver == null)
        {
            //_driver = CreateNewDriverInstance();
        }
        return _driver;
        }
    set { _driver = value;}
}

private void CreateNewDriverInstance()
{


}


}