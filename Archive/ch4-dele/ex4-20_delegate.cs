using System;


//4-20 
delegate void DelegateOne(); //델리게이트 매개변수 없음
delegate void DelegateTwo(int i); // 델리게이트 매개변수 있음

class DelegateClass
{
    public void MethodA()
    {
        Console.WriteLine("in the delegateClass.Method A..");
    }
    public void MethodB(int i)
    {
        Console.WriteLine("in the delegateClass.Method B.." + i);
    }


}

class DelegateCallApp
{
    public static void Main()
    {
        DelegateClass obj = new DelegateClass();
        DelegateOne d1 = new DelegateOne(obj.MethodA);
        DelegateTwo d2 = new DelegateTwo(obj.MethodB);

        d1(); //델리게이트 내의 MethodA 를 부른다.
        d2(10); //델리게이트 내의 MethodB(10)를 부른다.
    }

}