using System.Text;

public class PassValue
{
    private int SomePassValue1(int value)
    {
        return SomePassValue2(value);
    }

    private int SomePassValue2(int value)
    {
        return SomePassValue3(value);
    }

    private int SomePassValue3(int value)
    {
        return SomePassValue4(value);
    }

    private int SomePassValue4(int value)
    {
        value = 2;
        return value;
    }
    public void SomeMethod()
    {
        var passMe = 1;

        for (var x = 0; x < 20; x++)
        for (var i = 0; i < 50000000; i++)
            SomePassValue1(passMe);
    }
}