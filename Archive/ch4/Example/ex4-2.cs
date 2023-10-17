using System;
//ex4-2.cs
// static field 의 참조 오류 예제
public class StaticVsInstanceApp
{
    int instanceVariable;
    static int staticVariable;
    public static void Main()
    {
        StaticVsInstanceApp obj = new StaticVsInstanceApp();
        obj.instanceVariable = 10; //ok

        //StaticVsInstanceApp.instanceVariable = 10; // error 클래스 명으로 public 필드를 참조할수없다.
        StaticVsInstanceApp.staticVariable = 20; //ok

        // obj.staticVariable = 20; //error 객체 이름으로 참조할수없다.

        Console.WriteLine("instance Variable ={0} , static variable ={1}",
            obj.instanceVariable, StaticVsInstanceApp.staticVariable);
    }
}