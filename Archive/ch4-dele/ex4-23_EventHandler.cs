//이벤트 핸들링 시스템
//ex 4-23

using System;
public delegate void MyEventHandler(); //이벤트를 위한 델리게이트 정의

class Button
{
    public event MyEventHandler Push; //이벤트 선언
    public void OnPush()
    {
        if (Push != null) Push(); // 이벤트 발생
    }
}

class EventHandlerClass
{
    public void MyMethod()      //이벤트 처리기 작성
    {
        Console.WriteLine("In the EventHandlerClass.MyMethod ...");
    }
}

class EventHandlingApp
{
    public static void Main()
    {
        Button button = new Button();
        EventHandlerClass obj = new EventHandlerClass();
        button.Push += new MyEventHandler(obj.MyMethod); //등록
        button.OnPush();
    }
}