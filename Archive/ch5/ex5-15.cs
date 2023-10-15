using Shape;   //네임스페이스 추가
using System;

//ex 5-15.cs
namespace NamespaceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            //using 문을 사용하지 않는 경우
            //Shape.Rectangle rec = new Shape.Rectangle();
            rect.Width = 10;
            rect.Height = 20;
            Console.WriteLine("rect : " + rect);
        }
    }
}