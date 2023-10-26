using System;
using System.IO;

class ExerciseCh5_6_3
{
    public static void Main()
    {
        // 파일 생성 및 쓰기
        using (TextWriter w = File.CreateText("log.txt"))
        {
            w.WriteLine("This is line one"); // "log.txt" 파일에 첫 번째 줄 쓰기
            w.WriteLine("This is line two"); // "log.txt" 파일에 두 번째 줄 쓰기
        }

        // 파일 읽기
        using (TextReader r = File.OpenText("log.txt"))
        {
            int c;
            while ((c = r.Read()) != -1)
            {
                Console.WriteLine((char)c); // 파일에서 한 문자씩 읽어서 콘솔에 출력
            }
        }
    }
}
