using System;
using System.Runtime.CompilerServices;

//ch3-9-7-1.cs
// S= 1 + (1*2)+ (1*2*3) + ... +(1*2*3*...10)

class Program
{
    public static void Main(string[] args)
    {
        int destination = 10; //루프 횟수 선언

        int sum = 1; //각 루프의 총 합
        int tmp_sum; //루프의 합


        for (int i = 1; i <= destination; i++)
        {
            tmp_sum = Multiply(1, i); //1 부터 i 까지 곱하는 루프 
            sum += tmp_sum; //하위 루프의 결과를 합하기
        }
        Console.WriteLine(sum); //총 합 출력
    }
    public static int Multiply(int start, int end)
    {
        int sum = 1; //초기값 1 
        for (int i = start; i <= end; i++)
        {
            sum *= i; // 1 * 2 * 3 ... * i;
        }
        return sum;
    }
}
