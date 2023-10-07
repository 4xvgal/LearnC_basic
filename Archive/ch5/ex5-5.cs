using System;

//ex5-5.cs
class BaseClass
{
    virtual public void MethodA()
    {
        Console.WriteLine("Base MethodA");
    }
    virtual public void MethodB() { Console.WriteLine("Base MethodB"); }
    virtual public void MethodC() { Console.WriteLine("Base MethodC"); }
}
class DerivedClass : BaseClass
{
    new public void MethodA() { Console.WriteLine("Derived MethodA"); }
    override public void MethodB() { Console.WriteLine("Derived MethodB"); }
    public void MethodC()
    {
        Console.WriteLine("Derived MethodC");
    }
}

class VirtualMethodApp
{
    public static void Main()
    {
        BaseClass s = new DerivedClass(); //BaseClass 형 클래스, 객체 참조는 DerivedClass
        s.MethodA();    // new 키워드 메소드는 객체 형(base)를 따라감
        s.MethodB();    // 메소드 오버라이딩으로 객체 참조의 메소드 실행
        s.MethodC();    // 객체형을 따라 base따라감
    }
}