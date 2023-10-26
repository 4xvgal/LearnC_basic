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

class Celsius : Temperature
{
    public Celsius(double t) : base(t)
    {
        // Celsius 생성자: Celsius 객체를 초기화합니다.
    }

    // double to Celsius 형 변환 연산자
    public static implicit operator Celsius(double t)
    {
        double celsiusValue = t; // double 값을 그대로 Celsius로 변환
        return new Celsius(celsiusValue); // Celsius 객체 생성하여 반환
    }

    // Fahrenheit to Celsius 형 변환 연산자
    public static implicit operator Celsius(Fahrenheit f)
    {
        double celsiusValue = (f.Degree - 32) * 5 / 9; // Fahrenheit 값을 Celsius로 변환
        return new Celsius(celsiusValue); // Celsius 객체 생성하여 반환
    }

    // Celsius to double 형 변환 연산자
    public static implicit operator double(Celsius c)
    {
        return c.Degree; // Celsius 객체의 Degree 속성 값을 반환
    }
}

class Fahrenheit : Temperature
{
    public Fahrenheit(double t) : base(t)
    {
        // Fahrenheit 생성자: Fahrenheit 객체를 초기화합니다.
    }
}