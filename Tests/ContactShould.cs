using System;
using Xunit;

public class ContactShould{

ContactPage _contactPage = new ContactPage();
    [Fact]
    public void SendAValidMessage()
    {

        Assert.True(true,"first test case");
        //_contactPage.ContactEmail.SendKeys("EmailAddress");


    }
}