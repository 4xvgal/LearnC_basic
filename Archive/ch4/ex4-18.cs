//indexer
using System;


//ex4-18.cs

class Color
{
    //인덱서 구성
    private string[] color = new string[5];
    public string this[int index]
    {
        get { return color[index]; }
        set { color[index] = value; }
    }
}

class IndexerApp
{
    public static void Main()
    {
        Color c = new Color();
        // 객체[인덱스] = 값 으로 객체내 배열에 set
        c[0] = "WHITE";
        c[1] = "RED";
        c[2] = "YELLOW";
        c[3] = "BLUE";
        c[4] = "BLACK";
        for (int i = 0; i < 5; i++)
        {
            //객체[인덱스] 로 객체내 배열에 get 접근
            Console.WriteLine("Color is " + c[i]);
        }
    }
}