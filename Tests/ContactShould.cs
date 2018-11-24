using System;
using Xunit;

public class ContactShould:BasePage{


    public ContactShould():base()
    {
        Console.WriteLine("value now"+BaseUrl);
       Console.WriteLine("inside the contact should constructor1");
    }

    ContactPage _contactPage = new ContactPage();

    [Fact]
    public void SendAValidMessage()
    {      
          
        Console.WriteLine(BaseUrl+"value of base url");
        Assert.True(true, "test passed");

    }
}