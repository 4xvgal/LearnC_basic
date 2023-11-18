using System;
using System.IO;

class Program
{
    public static void Main()
    {


        Console.WriteLine("1. 프로그램 시작");
        String path = @"\\Mac\Home\Documents\codes\c#\LearnC#\bin\Debug\poet.txt";

        Console.WriteLine("2. 파일에 데이터 기록");
        FileStream fs = new FileStream(path, FileMode.Create);
        StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.Default);
        sw.BaseStream.Seek(0, SeekOrigin.End);

        sw.WriteLine("--------------------");
        sw.WriteLine(" 파일 내용 !!!!!");
        sw.WriteLine("--------------------");
        sw.Flush();
        sw.Close();

        Console.WriteLine("3. 파일에서 데이터 읽기");
        FileStream fs2 = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
        StreamReader sr = new StreamReader(fs2, System.Text.Encoding.Default);
        sr.BaseStream.Seek(0, SeekOrigin.Begin);
        while (sr.Peek() > -1)
        {
            Console.WriteLine(sr.ReadLine());
        }
        sr.Close();
        Console.WriteLine("4. 프로그램 종료");
    }

}