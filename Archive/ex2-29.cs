//ex2-29.cs
using System;
//박싱 언박싱 예제
class BoxingUnboxingApp
{
    public static void Main()
    {
        int foo = 526;
        object bar = foo;
        Console.WriteLine(bar);
        try
        {
            double d = (int)bar;
            Console.WriteLine(d);
        }
        catch (InvalidCastException e)
        {
            Console.WriteLine(e + "Error");
        }
    }
}