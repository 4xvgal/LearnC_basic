using System;

//형식 지정 문자
class FormattedOutputApp
{
    public static void Main()
    {
        Console.WriteLine("1) {0,-5},{1,5},{2,5}", 1.2, 1.2, 123.45);
        double d = Math.PI;
        Console.WriteLine("2) {0}", d);
        Console.WriteLine("3) {0:C}", d); //통화 표시
        Console.WriteLine("4) {0:E}", d);   //지수형태
        Console.WriteLine("5) {0:F}", d);   //고정 소수점 형태
        Console.WriteLine("6) {0:G}", d);   //고정 소수점 또는 지수 형태
        Console.WriteLine("7) {0:P}", d);   //백분율
        Console.WriteLine("8) {0:R}", d);   //결과 스트링을 다시 읽었을 때, 원 값과 동일함을 보장
        Console.WriteLine("9) {0:X}", 255); //16진수 (정수형만 가능)
    }
}