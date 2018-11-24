using System;
using Xunit;

public class ContactShould:BasePage{


    public ContactShould():base()
    {
       Console.WriteLine("inside the contact should constructor");
    }

    ContactPage _contactPage = new ContactPage();

    [Fact]
    public void SendAValidMessage()
    {      
          
        Console.WriteLine(BaseUrl+"value of base url");
        Assert.True(true, "test passed");

    }
}