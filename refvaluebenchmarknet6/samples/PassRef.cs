public class PassRef
{
    private int SomePassValue1(ref int value)
    {
        return SomePassValue2(ref value);
    }

    private int SomePassValue2(ref int value)
    {
        return SomePassValue3(ref value);
    }

    private int SomePassValue3(ref int value)
    {
        return SomePassValue4(ref value);
    }

    private int SomePassValue4(ref int value)
    {
        var result = 2;
        return result;
    }
    
    public void SomeMethod()
    {
        var passMe = 1;
        for (var x = 0; x < 20; x++)
        for (var i = 0; i < 50000000; i++)
            SomePassValue1(ref passMe);
    }
}