using System;

class BaseClass
{
    public bool Equal(object obj)
    {
        if (GetType() == obj.GetType()) // 현재 인스턴스와 매개변수로 전달된 객체의 형식을 비교
            return true; // 형식이 같으면 참 반환
        else
            return false; // 형식이 다르면 거짓 반환
    }
}

class DerivedClass : BaseClass
{
    class Exercise5_6_2
    {
        public static void Main()
        {
            BaseClass b1 = new BaseClass(); // BaseClass 형식의 객체 생성
            BaseClass b2 = new BaseClass(); // 또 다른 BaseClass 형식의 객체 생성

            DerivedClass d1 = new DerivedClass(); // DerivedClass 형식의 객체 생성
            DerivedClass d2 = new DerivedClass(); // 또 다른 DerivedClass 형식의 객체 생성

            if (b1.Equal(d1)) Console.WriteLine("Derived equals Base"); // b1은 BaseClass 형식이므로, d1은 DerivedClass 형식이므로 다른 형식이므로 출력되지 않음
            if (d1.Equal(b1)) Console.WriteLine("Base Equals Derived"); // d1은 DerivedClass 형식이므로, b1은 BaseClass 형식이므로 다른 형식이므로 출력되지 않음
            if (b1.Equal(b2)) Console.WriteLine("Base Equals Base."); // b1과 b2는 둘 다 BaseClass 형식이므로 같은 형식이므로 출력됨
            if (d1.Equal(d2)) Console.WriteLine("Derived Equals Derived"); // d1과 d2는 둘 다 DerivedClass 형식이므로 같은 형식이므로 출력됨
        }
    }
}
r