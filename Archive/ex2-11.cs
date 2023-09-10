//ex2-11.cs
using System;
using System.Globalization;

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
        for (i = 0; i < arrayOfArray.Length; i++)
            for (j = 0; j < arrayOfArray[i].Length; j++)
                arrayOfArray[i][j] = i * arrayOfArray.Length + j;
        for (i = 0; i < arrayOfArray.Length; i++)
        {
            for (j = 0; j < arrayOfArray[i].Length; j++)
                Console.Write(" " + arrayOfArray[i][j]);
            Console.WriteLine();
        }
    }
}