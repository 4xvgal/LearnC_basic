//ex2-11.cs
using System;
using System.Globalization;
//가변 길이 배열 만들기
class ArrayOfArrayApp
{
    public static void Main()
    {
        int[][] arrayOfArray = new int[3][]; //declaration
        int i, j;
        for (i = 0; i < arrayOfArray.Length; i++) //creation
        {
            arrayOfArray[i] = new int[i + 3];
        }
        for (i = 0; i < arrayOfArray.Length; i++) // 배열에 0 1 2, 4 5 6 7, 10 11.. 순으로 채우기
            for (j = 0; j < arrayOfArray[i].Length; j++)
                arrayOfArray[i][j] = i * arrayOfArray.Length + j;

        for (i = 0; i < arrayOfArray.Length; i++) //배열 출력하기
        {
            for (j = 0; j < arrayOfArray[i].Length; j++)
                Console.Write(" " + arrayOfArray[i][j]);
            Console.WriteLine();
        }
    }
}