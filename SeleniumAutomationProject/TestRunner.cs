using Xunit;
using System;

public class TestRunner : IDisposable
{
    public TestRunner ()
    {
        Console.WriteLine("inside the setup");
       
    }

    public void Dispose()
    {
        Console.Write("inside the teardown");
    }
}

