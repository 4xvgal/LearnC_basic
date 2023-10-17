using System;

//ch4-16 복소수 사칙연산 연산자 오버라이딩
class Complex
{
    public double real; //실수부 
    public double image; //허수부

    //생성자
    public Complex()
    {
        ;
    }
    public Complex(double real, double image)
    {
        this.real = real;
        this.image = image;
    }
    //사칙연산 - 연산자 오버라이딩 

    //더하기 

    public static Complex operator +(Complex a, Complex b) //더하기
    {
        Complex output = new Complex();
        output.real = a.real + b.real;
        output.image = a.image + b.image;

        return output;
    }
    public static Complex operator -(Complex a, Complex b) //감산
    {
        Complex output = new Complex();
        output.real = a.real - b.real;
        output.image = a.image - b.image;

        return output;
    }

    public static Complex operator *(Complex a, Complex b) //곱하기
    {
        Complex output = new Complex();
        output.real = a.real * b.real;
        output.image = a.image * b.image;

        return output;
    }
    public static Complex operator /(Complex a, Complex b) //나누기
    {
        Complex output = new Complex();
        output.real = a.real / b.real;
        output.image = a.image / b.image;

        return output;
    }



    //ToString() 메소드 오버라이딩
    public override string ToString()
    {
        return "(" + real + ", " + image + "i)";
    }
}

class Program
{
    public static void Main()
    {
        //Complex 복소수 객체 3개 생성
        Complex c, c1, c2;
        c1 = new Complex(1, 2);
        c2 = new Complex(3, 4);

        //연산자 중복 적용 
        c = c1 + c2;

        Console.WriteLine(c1 + " + " + c2 + " = " + c); // 더하기

        c = c1 - c2;
        Console.WriteLine(c1 + " - " + c2 + " = " + c); // 빼기

        c = c1 * c2;
        Console.WriteLine(c1 + " * " + c2 + " = " + c); // 곱하기

        c = c1 / c2;
        Console.WriteLine(c1 + " / " + c2 + " = " + c); // 나누기


    }
}