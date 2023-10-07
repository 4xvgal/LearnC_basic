using System;
using System.Xml;

//사칙연산 프로그램 

//추상 클래스 선언
abstract class Par_Operation
{
    public abstract double Add();
    public abstract double Sub();
}



//추상 클래스 Par_Operation 을 상속받는 Par_op_deriverd
class Par_Op_deri : Par_Operation
{
    //필드
    //double x, y;
    //프로퍼티
    public double x { get; set; }
    public double y { get; set; }


    //메소드
    //덧셈
    public override double Add()
    {
        return (x + y);
    }
    //뺄셈
    public override double Sub()
    {
        return (x - y);
    }
    //곱셈
    public double Multiply()
    {
        return (x * y);
    }
    //나눗셈
    public double Divide()
    {
        return (x / y);
    }

}


class Program
{
    public static void Main()
    {
        //객체 선언 및 할당
        Par_Op_deri par = new Par_Op_deri();
        //입력
        Console.Write("첫번째 실수를 입력:");
        par.x = double.Parse(Console.ReadLine());       //프로퍼티를 통해 set
        Console.Write("두번째 실수를 입력:");
        par.y = double.Parse(Console.ReadLine());

        Console.WriteLine("덧셈:" + par.Add() + "   뺄셈" + par.Sub());
        Console.WriteLine("곱셈:" + par.Multiply() + "   나눗셈" + par.Divide());

    }
}