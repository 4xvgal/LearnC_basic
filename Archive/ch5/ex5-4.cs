//ex 5-4.cs


using System;
class baseClass
{
    public void MethodA()
    {
        Console.WriteLine("In the baseClass ...");
    }
}

class DerivedClass : baseClass
{
    new public void MethodA() //new 키워드로 메소드 오버라이딩
    {
        Console.WriteLine("In DerivedClass ... Overriding !!!");

    }
    public void MethodA(int i) //메소드 오버로딩, 인수 int i 를 받는 메소드와 base 의 메소드를 둘다 사용가능함
    {
        Console.WriteLine("in DerivedClass ... Overloading !!!");
    }
}

class OverridingAndOverloadingApp
{
    public static void Main()
    {
        baseClass obj1 = new baseClass();
        DerivedClass obj2 = new DerivedClass();
        obj1.MethodA();
        obj2.MethodA(); // 오버라이딩된 메소드
        obj2.MethodA(1);        //오버로딩된 메소드
    }
}