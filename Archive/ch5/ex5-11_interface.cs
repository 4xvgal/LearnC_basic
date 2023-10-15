using System;

//ex5-11.cs
//인터페이스 예제
interface IRectangle
{
    void Area(int width, int height);
}

interface ITriangle
{
    void Area(int width, int height);
}

class Shape : IRectangle, ITriangle
{
    void IRectangle.Area(int width, int height)
    {
        Console.WriteLine("Rectangle Area : " + width * height);
    }
    void ITriangle.Area(int width, int height)
    {
        Console.WriteLine("Triangle Area: " + width * height / 2);
    }
}

class ImplementingInterfaceApp
{
    public static void Main()
    {
        Shape s = new Shape();
        //s.Area(10,10); //error - ambiguos !
        //s.IRectangle.Area(10,20); //error
        //s.ITriangle.Area(10,10); //error
        ((ITriangle)s).Area(20, 20); //캐스팅 업
        ((ITriangle)s).Area(20, 20);
        IRectangle r = s;
        ITriangle t = s;
        r.Area(30, 30);
        t.Area(30, 30);

    }
}