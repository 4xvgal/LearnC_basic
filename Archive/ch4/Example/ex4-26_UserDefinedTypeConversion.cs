Lusing System;
//ex 4-26
//형변환 연산자 중복

class Mile //마일 클래스
{
    public double distance; //거리 실수형 필드
    public Mile(double distance) //생성자 
    {
        this.distance = distance;
    }
    //Mile operator: double to Mile
    public static implicit operator Mile(double d) //묵시적 형변환
    {
        Mile m = new Mile(d);
        return m;
    }
    //Kilometer operator : Mile to kilometer
    public static explicit operator Kilometer(Mile m) //명시적 형변환 
    {
        return m.distance * 1.609;
    }
}

class Kilometer
{
    public double distance;
    public Kilometer(double distance)
    {
        this.distance = distance;
    }
    //Kilometer operator: double to Kilo
    public static implicit operator Kilometer(double d)
    {
        Kilometer k = new Kilometer(d);
        return k;
    }
    //Mile operator : Kilo to Mile
    public static explicit operator Mile(Kilometer k)
    {
        return k.distance / 1.609;
    }

}

class UserDefinedTypeConversionApp
{
    public static void Main()
    {
        Kilometer k = new Kilometer(100.0); //Km 객체 생성
        Mile m; //Mile 객체 생성

        m = (Mile)k; // km 를 Mile 형태로 명시적 형변환 100km -> 
        Console.WriteLine("{0} km = {1} mile", k.distance, m.distance);
        m = 65.0;
        k = (Kilometer)m; // km = (Kilometer) mile, mile객체를 kilo객체로 명시적 변환 65mile -> 104 kilometer
        Console.WriteLine("{0} mile = {1} km", m.distance, k.distance);

    }
}


