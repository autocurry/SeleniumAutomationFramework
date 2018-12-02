using Xunit;
using System;

public class TestTest:IDisposable{

[Fact]
public void sample()
{
    int a = 10;
    int b = 20;
    int x = a+b;
   
    
}

public void Dispose()
{
    Console.Write("inside the dispose");
}

}