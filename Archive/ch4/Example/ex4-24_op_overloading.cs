using System;

//ex4-24.cs
class Complex
{
    private double realPart;
    private double imagePart;
    public Complex(double rVal, double iVal) //클래스 선언
    {
        realPart = rVal; //실수부 
        imagePart = iVal; //허수부 
    }

    // 연산자 중복 + 연산자는 두개의 Complex 객체의 실수부와 허수부를 각각 더해 새로운 Complex 객체 리턴 
    public static Complex operator +(Complex x1, Complex x2)
    {
        Complex x = new Complex(0, 0);
        x.realPart = x1.realPart + x2.realPart;
        x.imagePart = x1.imagePart + x2.imagePart;
        return x;
    }

    //ToString 메소드 오버라이딩
    public override string ToString()
    {
        return "(" + realPart + ", " + imagePart + "i)";
    }
}

class OperatorOverloadingApp
{
    public static void Main()
    {
        //Complex 복소수 객체 3개 생성
        Complex c, c1, c2;
        c1 = new Complex(1, 2);
        c2 = new Complex(3, 4);

        //연산자 중복 적용 
        c = c1 + c2;

        Console.WriteLine(c1 + " + " + c2 + " = " + c);
    }
}
