using System;

public static class Page
{
    private static T GetPage<T>() where T : new()
    {
        var page = new T();
        return page;
    }

    public static HomePage Home
    {
        get { return GetPage<HomePage>(); }
    }

    public static CheckOutPage CheckOut
    {
        get { return GetPage<CheckOutPage>(); }
    }

     public static MyAccountPage MyAccount
    {
        get { return GetPage<MyAccountPage>(); }
    }

     public static RegisterPage Register
    {
        get { return GetPage<RegisterPage>(); }
    }
}