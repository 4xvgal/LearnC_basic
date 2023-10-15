using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

abstract class Figure
{
    public abstract double Area();  //넓이를 구하는 메소드
    public abstract double Girth(); //둘레를 구하는 메소드
}

//원 클래스
class Circle : Figure
{

    public int Radius;
    //추상 클래스 메소드 오버라이딩으로 구현
    public override double Area()
    {
        return 3.14 * (Radius * Radius);
        throw new NotImplementedException();
    }

    public override double Girth()
    {
        return 3.14 * 2 * Radius;
        throw new NotImplementedException();
    }
}

//사각형 클래스
class Rect : Figure
{
    public int Widght { get; set; }
    public int Height { get; set; }

    public override double Area()
    {
        return Widght * Height;

    }
    public override double Girth()
    {
        return 2 * (Widght + Height);

    }
}
//삼각형 클래스
class Triangle : Figure
{
    public int Base { get; set; }
    public int Height { get; set; }

    public override double Area()
    {
        return (Base * Height) / 2;
    }

    public override double Girth()
    {
        return Base * 3;
    }
}

class Program
{
    public static void Main()
    {
        Circle circle = new Circle();
        Rect rect = new Rect();
        Triangle tri = new Triangle();
        int menuInput = 0;

        while (menuInput != 4)
        {
            Console.WriteLine("연산을 선택하십시오 ");

            Console.WriteLine("1. 사각형 \n2. 원 \n3.삼각형\n4.Quit(q)");
            menuInput = int.Parse(Console.ReadLine());
            switch (menuInput)
            {
                case 1:
                    Console.Write("가로 입력 :");
                    rect.Widght = int.Parse(Console.ReadLine());
                    Console.Write("세로 입력 : ");
                    rect.Height = int.Parse(Console.ReadLine());
                    //출력
                    Console.WriteLine("결과\n------------------------");
                    Console.WriteLine("넓이 : " + rect.Area()); //넓이
                    Console.WriteLine("둘레 : " + rect.Girth()); //둘레
                    Console.WriteLine("-----------------------------");

                    break;
                case 2:
                    Console.Write("반지름 입력 : ");
                    circle.Radius = int.Parse(Console.ReadLine());
                    Console.WriteLine("결과\n------------------------");
                    Console.WriteLine("넓이: " + circle.Area());
                    Console.WriteLine("둘레: " + circle.Girth());
                    Console.WriteLine("-----------------------------");

                    break;
                case 3:
                    Console.Write("밑변 입력 :");
                    tri.Base = int.Parse(Console.ReadLine());
                    Console.Write("높이 입력 :");
                    tri.Height = int.Parse(Console.ReadLine());

                    Console.WriteLine("결과\n------------------------");
                    Console.WriteLine("넓이: " + tri.Area());
                    Console.WriteLine("둘레: " + tri.Girth());
                    Console.WriteLine("-----------------------------");
                    break;
                case 4:
                default:
                    Console.WriteLine("프로그램을 종료합니다. ");
                    break;
            }
        }

    }

}