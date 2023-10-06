using System;
//ex4-1 + method

class Fraction
{
    //field
    private int numerator;
    private int denominator;
    //생성자
    public Fraction(int n = 0, int d = 1)
    {//4-11 예제 3개의 생성자 중복됨.
        numerator = n;
        denominator = d;
    }

    //메소드
    public void PrintFraction()
    {
        Console.WriteLine(numerator + "/" + denominator);
    }
    //setNum
    public void setNumerator(int num)
    {
        numerator = num;
    }
    public void setData(int num, int denom)
    {
        numerator = num;
        denominator = denom;
    }
    //get
    public int getNumerator() { return numerator; }
    public int getDenominator() { return denominator; }
}
//실행 

class FractionApp
{
    public static void Main()
    {
        Fraction f = new Fraction(1, 2);
        //Fraction f;
        //f = new Fraction (1,2);
        f.PrintFraction();
        f.setData(2, 3);
        f.PrintFraction();
    }
}

