//StringIndexerApp

using System;
using System.Web;

class StringIndexer
{
    // 객체[문자열, 인덱스]  로 문자열의 인덱스에 해당하는 문자 리턴
    public char this[string str, int index]
    {
        get { return str[index]; }
    }
    //객체[문자열,인덱스,길이] 로 문자열의 인덱스부터 길이입력 까지의 문자열 리턴
    public string this[string str, int index, int len]
    {
        get { return str.Substring(index, len); }
    }

}


class StringIndexerApp
{
    public static void Main()
    {
        string str = "Hello";
        StringIndexer s = new StringIndexer();
        for (int i = 0; i < str.Length; i++)
        {
            Console.WriteLine("{0}[{1}] = {2}", str, i, s[str, i]);
        }
        Console.WriteLine("Substring of {0} is {1}", str, s[str, 2, 3]);

    }
}