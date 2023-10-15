using System;
using System.Runtime.CompilerServices;

// 연산자 중복, 인덱서 교재 실습문제 4-17
class Vector
{
    private int[] v;
    private int size;
    public Vector(int size)
    {
        v = new int[size];
        this.size = size;
    }
    //인덱서 구성
    public int this[int index]
    {
        get
        {
            return v[index];
        }
        set
        {
            v[index] = value;
        }
    }
    public static Vector operator ++(Vector v)
    {
        int size = v.getSize();
        for (int i = 0; i < size; i++)
        {
            v[i]++;
        }
        return v;
    }

    public static Vector operator --(Vector v)
    {
        int size = v.getSize();
        for (int i = 0; i < size; i++)
        {
            v[i]--;

        }
        return v;
    }
    private int getSize()
    {
        return size;
    }


}

class Program
{
    static void Main(string[] args)
    {
        Vector vector = new Vector(5); //크기 5의 벡터 생성

        // 벡터에 10,11,12,13,14 로 값을 초기화

        for (int i = 0; i < 5; i++)
        {
            vector[i] = i + 10;
        }
        //for 벡터 내용 출력
        Console.WriteLine("벡터 출력");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(vector[i]);
        }
        //벡터의 연산자 중복으로 ++ 연산 수행
        vector++;
        //벡터의 내용 출력
        Console.WriteLine("벡터 출력");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(vector[i]);
        }
        //벡터의 연산잔 중복으로 -- 연산 수행 
        vector--;
        //벡터의 내용 출력
        Console.WriteLine("벡터 출력");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(vector[i]);
        }
    }
}
