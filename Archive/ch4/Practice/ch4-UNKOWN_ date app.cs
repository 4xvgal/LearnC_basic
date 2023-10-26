using System;

class Date
{
    private int day, month, year;
    public Date(int mm, int dd, int yy)
    {
        day = dd;
        month = mm;
        year = yy;
    }

    //연산자 중복
    public static Date operator +(Date d, int n)
    {
        d.day = d.day + n;
        return d;

    }
    public static Date operator -(Date d, int n)
    {
        d.day -= n;
        return d;
    }
    // 대칭 중복해줘야하는 연산자 중복
    public static bool operator ==(Date a, Date b)
    {
        if (a.year == b.year && a.month == b.month && a.day == b.day)
        {
            return true;
        }
        return false;
    }
    public static bool operator !=(Date a, Date b)
    { return false; }
    //대칭중복 < > 

    public static bool operator >(Date a, Date b)
    {
        if (a.year > b.year && a.month > b.month && a.day > b.day)
            return true;
        return false;
    }
    public static bool operator <(Date a, Date b)
    {
        if (a.year < b.year && a.month < b.month && a.day < b.day)
            return true;
        return false;
    }
    // ++ -- 중복
    public static Date operator ++(Date a)
    {
        a.day++;
        return a;
    }
    public static Date operator --(Date a)
    {
        a.day--;
        return a;
    }

    //ToString 메소드 중복
    override public string ToString()
    {
        return string.Format("{0}/{1}/{2}", month, day, year);
    }
}

class Program
{
    static void Main()
    {
        Date date1 = new Date(10, 26, 2023);
        Date date2 = new Date(10, 27, 2023);

        // Test addition and subtraction operators
        Console.WriteLine("Original date1: " + date1);
        date1 = date1 + 5;
        Console.WriteLine("date1 + 5: " + date1);
        date1 = date1 - 2;
        Console.WriteLine("date1 - 2: " + date1);

        // Test equality and inequality operators
        Console.WriteLine("date1 == date2: " + (date1 == date2));
        Console.WriteLine("date1 != date2: " + (date1 != date2));

        // Test greater than and less than operators
        Console.WriteLine("date1 > date2: " + (date1 > date2));
        Console.WriteLine("date1 < date2: " + (date1 < date2));

        // Test increment and decrement operators
        Console.WriteLine("Original date1: " + date1);
        date1++;
        Console.WriteLine("date1++: " + date1);
        date1--;
        Console.WriteLine("date1--: " + date1);

        // Testing ToString method
        Console.WriteLine("date1.ToString(): " + date1.ToString());
    }
}
