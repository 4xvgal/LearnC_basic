//ex 4-6.cs

using System;


class integer
{
    public int i;
    public integer(int i)
    {
        this.i = i;
    }
}
//오브젝트를 callbyReference 방식 매개변수로 전달
class CallByObjectReferenceApp      
{
    static void Swap(integer x, integer y)
    {
        int tmp = x.i; x.i = y.i; y.i = tmp;
        Console.WriteLine(" Swap: x={0},y={1}", x.i, y.i);
    }
    public static void Main()
    {
        integer x = new integer(1);
        integer y = new integer(2);
        Console.WriteLine("Before: x = {0}, y={1}", x.i, y.i);
        Swap(x, y);
        Console.WriteLine("After: x={0},y={1}", x.i, y.i);
    }
}

