//week 2 - double digit
using System;
using System.Globalization;


class calc { 
    public static void Main(String[] args)
    {
        string value_a , value_b ;
        double des_a, des_b ;
        // input
        Console.WriteLine("Type first digit ");
        value_a = Console.ReadLine();
        Console.WriteLine("Type Second digit ");
        value_b = Console.ReadLine();
        // convert
        des_a = double.Parse(value_a);
        des_b = double.Parse(value_b);
        // printing converted string
        Console.WriteLine("Converted digits (string - > double)");
        Console.WriteLine(des_a.ToString() + "      " + des_b.ToString());
    }
}


/*
  2. 수업활동일지 문제
다음 결과를 출력하는 산을 수행하는 계산프로그램 작성하시오
콘솔 응용 프로그램으로 프로젝트를 만든다.
숫자 두 개를 Console.ReadLine 메소드를 통해 입력받는다.
키보드로 입력받은 값을 string 형으로 저장한다.
string 형 변수에 저장된 값을 Parse 메소드를 사용해서 각각 double 형 변수에 저장한다.
*/