using System;
//ex4-14.cs
class Fraction
{
    private int numerator;  //분자
    private int denominator;    //분모
    public int Numerrator
    {
        get { return numerator; }
        set { numerator = value; }
    }
    public int Denominator
    {
        get { return denominator; }
        set { denominator = value; }
    }
    public override string ToString()
    {
        return (numerator + "/" + denominator);
    }
}


class PropertyApp
{
    public static void Main()
    {
        Fraction f = new Fraction(); int i;
        f.Numerrator = 1; //invoke set-accessor in Numerator
        i = f.Numerrator + 1; // invoke get-accessor in Numerator
        f.Denominator = i;      //invoke set-accessor in Denominator
        Console.WriteLine(f.ToString());
    }
}