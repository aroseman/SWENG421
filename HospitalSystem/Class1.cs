using System;

public class Class1
{
	public Class1()
	{
	}

    public void DoWork()
    {
        Login l = new Login();
        var what = l.MyProperty;
        what++;
        l.MyProperty = what;
    }
}
