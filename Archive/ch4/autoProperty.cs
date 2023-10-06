using System;
//자동 프로퍼티  

class Fraction
{
    private int numerator;
    private int denominator;

    public int Numerator { get; set; } // 분자 자동 프로퍼티
    public int Denominator { get; set; } // 분모 자동 프로퍼티
    //ToString 기본 메소드 오버라이딩
    public override string ToString()
    {
        return Numerator + "/" + Denominator; // 필드 명이 아닌 프로퍼티로 접근?
    }
}
class PropertyApp
{
    public static void Main()
    {
        Fraction f = new Fraction(); // 선언
        int i = 0;
        f.Numerator = 1; //invoke set-accessor in Numerator
        i = f.Numerator + 1; // invoke get-accessor in Numerator
        f.Denominator = i;      //invoke set-accessor in Denominator
        Console.WriteLine(f.ToString());
    }
}
