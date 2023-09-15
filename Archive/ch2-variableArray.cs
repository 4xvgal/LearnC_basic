using System;
using System.Globalization;
//동적 배열 클랙스
class variableArray
{
    public static void Main(string[] args)
    {
        //동적 할당 배열 생성
        int[,] num = new int[2, 3];
        //배열 값 저장
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                num[i, j] = i;
            }
        }
        //배열 값 출력
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write("{0}  ", num[i, j]);
            }
            Console.WriteLine();
        }
    }
}