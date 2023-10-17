using System;
using System.Xml;
//ch 4-11
class Fraction
{
    //field
    //프로퍼티 사용 (propfull)
    private int numerator; //분자
    private int denominator; //분모
    public int Numerator
    {
        get { return numerator; }
        set { numerator = value; }
    }
    public int Denominator
    {
        get { return denominator; }
        set { denominator = value; }
    }


    //생성자
    public Fraction(int num, int denom) //두개의 정수를 받아 초기화
    {
        Numerator = num;
        Denominator = denom;
    }
    public Fraction(int num) //한개의 정수를 받아 초기화
    {
        Numerator = num;
    }
    public Fraction()
    {
        Numerator = 0;
        Denominator = 0;
    }
    public void setData(int num, int denom)
    {
        Numerator = num;
        Denominator = denom;
    }
    //메소드
    public override string ToString()
    {
        return numerator + "/" + denominator;
    }
    public int GetGcd(int a, int b)
    {
        if (b == 0)
        {
            return a;
        }
        else
        {
            return GetGcd(b, a % b);
        }
    }
    public Fraction ReducedFraction(Fraction a) //기약분수 구하기
    {

        Fraction output = new Fraction();

        int num = a.Numerator;
        int denom = a.Denominator;
        int gcd = GetGcd(num, denom);

        num = num / gcd;
        denom = denom / gcd;

        output.setData(num, denom);

        return output;
    }
    public Fraction AddFraction(Fraction a, Fraction b)
    {
        Fraction output = new Fraction();

        output.Numerator = (a.Numerator + b.Numerator);
        output.Denominator = (a.Denominator + b.Denominator);

        return output;
    }
    public Fraction SubFraction(Fraction a, Fraction b)
    {
        Fraction output = new Fraction();

        output.Numerator = (a.Numerator - b.Numerator);
        output.Denominator = (a.Denominator - b.Denominator);

        return output;
    }
    public Fraction MulFraction(Fraction a, Fraction b)
    {
        Fraction output = new Fraction();

        output.Numerator = (a.Numerator * b.Numerator);
        output.Denominator = (a.Denominator * b.Denominator);

        return output;
    }
    public Fraction DivFraction(Fraction a, Fraction b)
    {
        Fraction output = new Fraction();

        output.Numerator = (a.Numerator / b.Numerator);
        output.Denominator = (a.Denominator / b.Denominator);

        return output;
    }
}
//실행 
class Program
{
    public static void Main(string[] args)
    {
        //기약분수 메소드 테스트 
        Fraction a = new Fraction(2, 4);
        Fraction b = a.ReducedFraction(a);

        Console.WriteLine("ReducingFraction \nbefore : {0}     after: {1}\n", a.ToString(), b.ToString());

        a = new Fraction(4, 5);
        b = new Fraction(2, 7);
        Fraction output = new Fraction();
        Console.WriteLine("FourBasic Operation test");
        Console.WriteLine("a : {0}, b: {1}", a.ToString(), b.ToString());
        Console.WriteLine("Add :{0}     Sub:{1}", output.ReducedFraction(output.AddFraction(a, b)), output.ReducedFraction(output.SubFraction(a, b)));
        Console.WriteLine("Mul: {0}     Div: {1}", output.ReducedFraction(output.MulFraction(a, b)), output.ReducedFraction(output.DivFraction(a, b)));
    }
}