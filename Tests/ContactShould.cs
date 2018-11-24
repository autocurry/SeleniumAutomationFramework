using System;
using Xunit;

public class ContactShould:BasePage{


    public ContactShould()
    {

    }

ContactPage _contactPage = new ContactPage();
    [Fact]
    public void SendAValidMessage()
    {        
        _contactPage.ContactEmail.SendKeys("EmailAddress");

    }
}