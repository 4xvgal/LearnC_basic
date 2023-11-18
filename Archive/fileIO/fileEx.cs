
using System;
using System.IO;

public class Program
{

    public static void Main()
    {
        Console.WriteLine("1.프로그램 시작");
        Console.WriteLine("2. 파일 스트림 생성");

        FileStream fs = File.OpenRead("program.cs");


        StreamReader r = new StreamReader(fs, System.Text.Encoding.Default);

        r.BaseStream.Seek(0, SeekOrigin.Begin);

        Console.WriteLine("3. 파일 읽어와서 디스플레이 하기");

        while (r.Peek() > -1)
        {
            Console.WriteLine("r.ReadLine()");

        }
        r.Close();
        Console.WriteLine("4.프로그램 끝");
    }

}