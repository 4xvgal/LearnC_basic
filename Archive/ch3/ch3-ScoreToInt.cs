using System;
using System.IO;

//성적 점수환산 프로그램
class ScoreToInt
{
    public static void Main()
    {
        string score = "";

        Console.WriteLine(" 점수를 입력하시오 ");

        while (score != "end")
        {
            score = Console.ReadLine();
            scoreConv(score);
        }
    }
    static void scoreConv(string s)
    {
        switch (s)
        {
            case "a":

            case "A":
                Console.WriteLine("90점 이상입니다.");
                break;

            case "b":
            case "B":
                Console.WriteLine("80점에서 89점 사이입니다.");
                break;

            case "c":
            case "C":
                Console.WriteLine("70점에 79점 사이입니다.");
                break;

            case "d":
            case "D":
                Console.WriteLine("60점에서 69점 사이입니다.");
                break;
            case "f":
            case "F":
                Console.WriteLine("60점 이하입니다.");
                break;
            default:
                Console.WriteLine("입력이 잘못되었습니다");
                break;
        }
    }
}
