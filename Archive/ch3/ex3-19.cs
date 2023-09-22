using System;
//ex 3-19
//오버플로 검사, 예외처리문
class OverFlowApp
{
    public static void Main()
    {
        int i, max = int.MaxValue;
        try
        {
            Console.WriteLine("Start of try statement");
            i = max + 1;            //defualt : don't check overflow.
            Console.WriteLine("After defualt overflow");
            unchecked
            {
                i = max + 1; //don't check overflow intensionally.
            }
            Console.WriteLine("After unchecked statement");
            checked //오버플로를 검사함
            {
                i = max + 1; // check overflow;
            }
            Console.WriteLine("After checked statement");
        }
        catch (OverflowException e) // 오버플로 발생시 실행됨
        {
            Console.WriteLine("caught an OverflowException");
        }
    }
}