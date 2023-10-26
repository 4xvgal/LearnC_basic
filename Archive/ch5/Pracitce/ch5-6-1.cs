using System;

class BaseClass { public static int supNum = 100; } //베이스 클래스의 정적필드 supNum = 100

class DerivedClass : BaseClass
{
    public static int subNum = 200; //상속받은 클래스의 정적필드 subNum = 200
}
public class Ex
{
    public static void Main()
    {
        Console.Write(BaseClass.supNum + ", " + DerivedClass.supNum); //베이스의 필드, Derived의 베이스 클래스 각각 호출 100, 100
        Console.WriteLine(", " + DerivedClass.subNum); //상속 클래스의 필드인 subNum호출 , 200
        //출력 : 100, 100, 200
    }
}