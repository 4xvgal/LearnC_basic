using System;
using System.IO;

class Program
{
    public class Student
    {
        public String Name { get; set; }
        public String Id { get; set; }
        public String Phone { get; set; }

        String path = "C:/Users/mac2/Documents/tmp/std.txt";
        //메서드
        public void fileInput()
        {
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.Default);
            sw.BaseStream.Seek(0, SeekOrigin.End);
            sw.Write(Name + " " + Id + " " + Phone);
            sw.WriteLine();
            sw.Close();
        }
        public void fileOutput()
        {
            FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(file, System.Text.Encoding.Default);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            while (sr.Peek() > -1)
            {
                Console.WriteLine(sr.ReadLine());
            }
            file.Close();
            sr.Close();
        }
        public void fileClear()
        {
            //make file blank
            FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(file, System.Text.Encoding.Default);
            sw.Write("");
            sw.Close();
        }
    }


    public static void Main()
    {

        while (true)
        {
            Console.WriteLine("=============================");
            Console.WriteLine("1. 학생 정보 입력");
            Console.WriteLine("2. 학생 정보 출력");
            Console.WriteLine("3. 종료");
            Console.WriteLine("4. 파일 삭제");
            Console.WriteLine("=============================");

            int menuSelect = int.Parse(Console.ReadLine());
            Student std = new Student();


            switch (menuSelect)
            {
                case 1:
                    // 학생 정보 입력 실행
                    Console.Write("성명 : ");
                    std.Name = Console.ReadLine().ToString();
                    Console.Write("학번 : ");
                    std.Id = Console.ReadLine().ToString();
                    Console.Write("핸드폰 :");
                    std.Phone = Console.ReadLine().ToString();
                    //파일에 저장
                    std.fileInput();

                    break;
                case 2:
                    std.fileOutput();
                    break;
                case 3:
                    // 종료 실행
                    Console.WriteLine("프로그램 종료");
                    return;
                case 4:
                    std.fileClear();
                    break;
                default:
                    Console.WriteLine("잘못된 입력입니다.");

                    break;
            }
        }
    }
}
