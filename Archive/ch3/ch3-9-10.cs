using System;
//3-9-10 
//동전 거슬러주기
class Program
{
    public static void Main()
    {
        Console.WriteLine("상품의 가격을 입력하십시오");
        int price = int.Parse(Console.ReadLine());

        int[] list = new int[6];
        list[0] = 500;
        list[1] = 100;
        list[2] = 50;
        list[3] = 10;
        list[4] = 5;
        list[5] = 1;
        int[] outputList; //출력 받을 리스트 
        outputList = CountingChange(list, price);

        Console.WriteLine();
        for (int i = 0; i < outputList.Length; i++)
        {
            Console.WriteLine("{0} : {1}", list[i], outputList[i]);
        }
        Console.WriteLine("거스름돈 : {0}", 1000 - price);
    }
    public static int[] CountingChange(int[] coinList, int price) //거스름돈 계산 함수
    {
        int[] countList = new int[coinList.Length];
        int change = 1000 - price;
        for (int i = 0; i < coinList.Length; i++)
        {

            countList[i] = change / coinList[i];
            change = change % coinList[i];
        }

        return countList;
    }
}
