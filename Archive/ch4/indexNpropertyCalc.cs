//cal_sum(), cal_prod() 메소드 구현


using System;

class Calc
{
    //선언
    private int n;
    private int[] array;

    //프로퍼티 메소드
    public int N
    {
        get { return n; }
        set { n = value; }
    }
    //인덱서
    public int this[int index]
    {
        get { return array[index]; }
        set { array[index] = value; }

    }

    //생성자
    public Calc(int n)
    {
        this.n = n;
        array = new int[n + 1];

    }
    //메소드
    public int Cal_sum()
    {
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i;

        }
        return sum;
    }
    //곱
    public int Cal_prod()
    {
        int mul = 1;
        for (int i = 1; i <= n; i++)
        {
            mul *= array[i];
        }
        return mul;

    }
}


class Program
{
    public static void Main()
    {
        Console.WriteLine("숫자입력하시오");
        int num = int.Parse(Console.ReadLine());
        Calc calc = new Calc(num);
        for (int i = 1; i <= num; i++)
        {
            calc[i] = i;
        }
        Console.WriteLine("합계: " + calc.Cal_sum() + "	곱:" + calc.Cal_prod());
    }
}