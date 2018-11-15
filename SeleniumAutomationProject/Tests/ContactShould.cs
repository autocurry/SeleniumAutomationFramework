using System;
using Xunit;

public class ContactShould{

ContactPage _contactPage = new ContactPage();
    [Fact]
    public void SendAValidMessage()
    {

        _contactPage.ContactEmail.SendKeys(EmailAddress);


    }
}