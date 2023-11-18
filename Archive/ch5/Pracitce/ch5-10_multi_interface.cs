using System;

interface IPropertyCounter
{
    int Count { get; set; }

}

interface IMethodCounter
{
    int Count(int i);

}

interface ICounter : IPropertyCounter, IMethodCounter
{

}


class InterfaceParameter : ICounter //인터페이스 구현
{
    public int Count { get; set; } //Iproperty

    int IMethodCounter.Count(int i) //imethodcounter
    {
        Count = i;
        return Count;
    }

}


class Program
{
    public static void Main(string[] args)
    {
        InterfaceParameter a = new InterfaceParameter();
        a.Count = 1;
        Console.WriteLine(a.Count);


        ((IMethodCounter)a).Count(3); //인터페이스 이름으로 명시적으로 호출 (네임스페이스 지정하여 호출)
        Console.WriteLine(a.Count);


        IMethodCounter m = a;//  업캐스팅
        m.Count(5);
        //Console.WriteLine(m.Count) //오류. IMehodCounter는 get 프로퍼티가 없다.
    }
}