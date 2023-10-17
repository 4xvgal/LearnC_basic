//구구단 출력프로그램
//ch3-9-8.cs

using System;

class Program
{
    public static void Main()
    {
        for (int i = 2; i <= 9; i++)
        {
            for (int j = 1; j <= 9; j++)
            {
                Console.Write("{0}*{1} = {2} | ", j, i, i * j); // j * i 형식으로 출력하여 가로로 출력
            }
            Console.WriteLine();
        }
    }
}