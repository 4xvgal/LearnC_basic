using System;
//8개의 숫자를 입력받아 역순 출력
class printIntegers
{
    static void Main()
    {
        int[] a = new int[8];
        Console.WriteLine("8개의 숫자를 입력하시오");
        for (int i = 0; i < 8; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }
        print_array(a);
    }

    static void print_array(int[] input, string msg = "Print Array from end") //배열 출력 메소드
    {
        Console.WriteLine(msg);
        int size = input.Length;
        for (int i = size - 1; i >= 0; i--)
            Console.WriteLine(input[i]);
    }
}