using System;
using System.ComponentModel;

//ch5-8.cs
// Abstract Class
abstract class Figure
{
    public abstract void Area(); //넓이를 계산
    public abstract void Girth(); //둘레를 계산
    public abstract void Draw();  //도형을 출력

}
class Rect : Figure
{
    int x, y; //가로 세로 필드
    double area; //넓이 저장 필드
    double girth; //둘레 저장 필드
    public void setData(int x, int y) //필드 설정 메소드 프로퍼티로 전환가능
    {
        this.x = x;
        this.y = y;
    }

    public override void Area() //넓이 계산 구현부
    {
        area = x * y;
    }
    public override void Girth() //둘레 계산 구현부
    {
        girth = x * 2 + y * 2;
    }
    public override void Draw() //도형 출력 구현부
    {
        Console.WriteLine("Draw Called\nArea : {0}, Girth : {1}", area, girth);
    }

}
class Circle : Figure //원 클래스
{
    int Radius; //반지름 필드
    double area; //넓이 저장 필드
    double girth; //둘레 저장 필드

    public void setData(int radius) //필드 설정 메소드
    {
        Radius = radius;
    }
    public override void Area() // 넓이 계산 메소드
    {
        area = 3.14 * Radius * Radius;
    }
    public override void Girth() //둘레 계산 메소드
    {
        girth = 3.14 * 2 * Radius;

    }
    public override void Draw()
    {
        Console.WriteLine("Draw called \nArea : {0} , Girth : {1}", area, girth);

    }
}


class Program
{
    public static void Main()
    {
        Circle circle = new Circle();

        circle.setData(10);
        circle.Area();
        circle.Girth();

        circle.Draw();

        //사각형

        Rect rect = new Rect();
        rect.setData(3, 3);
        rect.Area();
        rect.Girth();
        rect.Draw();
    }



}