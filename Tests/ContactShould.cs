using System;
using Xunit;

public class ContactShould{

ContactPage _contactPage = new ContactPage();
    [Fact]
    public void SendAValidMessage()
    {

        Assert.True(false,"failing the test intentionally");
        //_contactPage.ContactEmail.SendKeys("EmailAddress");


    }
}