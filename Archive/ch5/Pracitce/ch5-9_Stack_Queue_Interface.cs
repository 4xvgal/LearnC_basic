//ch5-9
//Interface 


using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Proxies;
using System.Security.Policy;

interface IOperation
{
    void Insert(string str); //삽입 메소드
    string Delete(); //삭제후 반환 메소드
    bool Search(string str); //검색 메소드 
    string GetCrurrentElt(); //최상단 원소 반환
    int NumOfElements(); //스택에 존재하는 원소의 개수 반환

}

//인터페이스를 사용하여 Stack 클래스를 구현

public class Stack : IOperation
{
    int top; //최상단 인덱스
    int[] arr; // 요소 저장할 배열
    public Stack(int size) //생성자로 배열 초기화
    {
        arr = new int[size]; //size 만큼 배열 할당
        top = 0;            //top인덱스 초기화
    }
    public string Delete() //pop 연산
    {
        if (top == 0)
        {
            throw new System.NotImplementedException("Error: couldn't Delete elements, stack is empty");
        }
        else
        {
            string tmp = Convert.ToString(arr[top]); //int 요소 를 문자열로 변환
            top--; //최상위 인덱스 감소
            return tmp; //문자열 반환
        }
    }
    public void Insert(string str) //푸쉬
    {
        if (top == 10)
        {
            throw new System.NotImplementedException("Error: Couldn't Insert Elements, Stack is full");
        }
        else
        {
            top++; //최상단 인덱스 증감
            arr[top] = int.Parse(str); //배열
        }
    }
    public string GetCrurrentElt() //최상단 요소 리턴
    {
        return Convert.ToString(arr[top]);
    }
    public int NumOfElements() //현재 요소 갯수 리턴
    {
        return top;
        throw new System.NotImplementedException();
    }

    public bool Search(string str) //입력받은 요소가 스택에 존재하면 true 리턴
    {
        int tmp = int.Parse(str);
        Console.WriteLine("searching " + tmp);
        for (int i = 0; i < top + 1; i++)
        {
            if (tmp == arr[i]) return true;
        }
        return false;
        throw new System.NotImplementedException();
    }

}

public class MyQueue : IOperation
{
    int[] arr;
    int rear;
    int front;

    public MyQueue(int size)
    {
        arr = new int[size]; // 주어진 크기만큼 큐를 위한 배열 할당
        rear = 0;
        front = 0;
    }
    public string Delete() //큐에서 맨앞을 삭제
    {
        if (front == arr.Length)
        {
            throw new System.NotImplementedException("Queue is Empty");
        }
        else
        {

        }
        string tmp = Convert.ToString(arr[front]);
        front++;
        return tmp;
    }

    public string GetCrurrentElt() //큐의 front에 있는 원소를 반환
    {
        //Console.WriteLine(arr[front]);
        return Convert.ToString(arr[front]);
    }

    public void Insert(string str) //큐에서 rear 에 추가
    {
        if (rear == arr.Length)
        {
            throw new System.NotImplementedException("Error : queue is full");
        }
        else
        {
            arr[rear++] = int.Parse(str);
            //rear++;
        }
    }

    public int NumOfElements() //큐에 존재하는 원소의 개수를 반환
    {
        return rear - front;
    }

    public bool Search(string str) //큐에서 주어진 원소의 존재여부를 반환한다.
    {
        for (int i = front; i <= rear; i++)
        {
            if (int.Parse(str) == arr[i]) { return true; }
        }
        return false;
    }
}
class Program
{
    public static void Main()
    {
        //스택 테스트
        Console.WriteLine("-- Stack test --");
        Stack a = new Stack(10);
        a.Insert("3");
        a.Insert("4");
        a.Insert("5");
        Console.WriteLine("pop : {0}", a.Delete());
        Console.WriteLine("current stack size :{0}", a.NumOfElements());
        Console.WriteLine("top value :{0}", a.GetCrurrentElt());
        Console.WriteLine("Searching '4' : {0}", a.Search("4"));

        //큐 테스트
        Console.WriteLine("\n-- Queue Test --");
        MyQueue b = new MyQueue(10);
        b.Insert("5");
        b.Insert("6");
        b.Insert("7");
        Console.WriteLine("dequeue : {0}", b.Delete());
        Console.WriteLine("current queue size :{0}", b.NumOfElements());
        Console.WriteLine("Front value : " + b.GetCrurrentElt());
        Console.WriteLine("Searching '4' : " + b.Search("4"));

    }
}