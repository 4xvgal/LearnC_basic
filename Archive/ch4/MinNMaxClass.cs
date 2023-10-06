using System;
using System.Globalization;

//최소 최대값 실습
class Program
{
    public static void Main()
    {
        MinMax arr = new MinMax();
        double min, max;
        Console.WriteLine("=============================");
        Console.WriteLine("0. 데이터 입력(5개:) ");
        Console.WriteLine("1.최소값");
        Console.WriteLine("2.최대값");
        Console.WriteLine("3. 프로그램 종료");

        while (true)
        {
            Console.WriteLine("메뉴 선택");
            int select = int.Parse(Console.ReadLine());
            switch (select)
            {
                case 0:
                    arr.input();
                    break;
                case 1:
                    min = arr.min();
                    Console.WriteLine(" 최소값 : {0}\n", min);
                    break;
                case 2:
                    max = arr.max();
                    Console.WriteLine("최대값 : {0}\n", max);
                    break;
                case 3:
                    Console.WriteLine("프로그램 종료합니다.");
                    break;
                default: break;
            }
        }
    }
}

class MinMax
{
    //field
    private double[] num;
    private double Min, Max;

    //생성자
    public MinMax()
    {
        num = new double[5];
        Min = 99999;
        Max = -99999;
    }

    //메소드
    //최소값 리턴
    public double min()
    {
        for (int i = 0; i < 5; i++)
        {
            if (Min > num[i])
            {
                Min = num[i];
            }
        }
        return Min;
    }
    //최대값 리턴
    public double max()
    {
        for (int i = 0; i < 5; i++)
        {
            if (Max < num[i])
            {
                Max = num[i];
            }
        }
        return Max;
    }

    //배열에 입력 메소드
    public void input()
    {
        double tmp;
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("{0} 번째 값 입력 :", i);
            tmp = double.Parse(Console.ReadLine());
        }
    }


}