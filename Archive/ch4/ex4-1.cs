using System;
//ex4-1
class Fraction
{
    //field
    private int numerator;
    private int denominator;
    //생성자
    public Fraction(int num, int denom)
    {
        numerator = num;
        denominator = denom;
    }
    //메소드
    public void PrintFraction()
    {
        Console.WriteLine(numerator + "/" + denominator);
    }
}
//실행 

class FractionApp
{
    public static void Main()
    {
        Fraction f = new Fraction(1, 2);
        f.PrintFraction();
    }
}