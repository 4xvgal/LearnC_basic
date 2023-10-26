class Temperature
{
    double degree;
    public Temperature(double degree)
    {
        this.degree = degree;
    }

    public double Degree
    {
        get { return degree; }
    }
}

class Celsius :Temperature
{
    public Celsius(double t) : base(t)
    {

    }
    //double to celcisus
    public static implicit operator Celsius(double t)
    {
        return new Celsius(t);
    }

    //Fahrenheit to celcisus
    public static implicit operator Celsius(Fahrenheit f)
    {
        double celsiusValue = (f.Degree - 32) * 5 / 9;
        return new Celsius(celsiusValue);
    }
    //Celcius to double
    public static implicit operator double(Celsius c)
    {
        return c.Degree;
    }
}

class Fahrenheit :Temperature
{
    public Fahrenheit(double t) : base(t) { }
}