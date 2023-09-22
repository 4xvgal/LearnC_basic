using System;
//ex3-15
// foreach 사용법

class ForEachApp
{
    public static void Main()
    {
        string[] color = { "red", "green", "blue" };
        foreach (string s in color)
            Console.WriteLine(s);
    }
}