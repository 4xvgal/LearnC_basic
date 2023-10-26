using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

//모의 테스트 문제 
//추상클래스, 프로퍼티, 상속, 정적 클래스, 정적메소드
abstract class Person
{
    public String Name { get; set; } //이름 필드 선언, 프로퍼티 설정
    public abstract void show(); // ToString 과 같은 메소드

}

class Emp : Person
{
    int[] jum; //실적 배열 필드 선언
    double Avg; // 평균 필드

    //생성자 
    public Emp()
    {
        jum = new int[3];
    }
    public Emp(String name, int[] jum)
    {
        this.Name = name;
        this.jum = jum;
    }
    //프로퍼티 ( 접근 메소드)
    public double getAvg()
    {
        return Avg;
    }
    //jum 배열에 대한 인덱서 
    public int this[int index] //indexer 치고 탭두번
    {
        get { return jum[index]; }
        set { jum[index] = value; }
    }
    //파생 클래스 구현
    public override void show()
    {
        if (Name == null)
        {
            Name = null;
        }
        //Console.WriteLine(Name + "  " + jum[0] + "  " + jum[1] + "  " + jum[2] + "  " + Avg);
        Console.WriteLine("{0,-10}      {1,-10}     {2,-10}     {3,-10}     {4,-10}", Name, jum[0], jum[1], jum[2], Avg.ToString("N2"));
    }

    //메소드

    public void com()
    {
        Avg = (double)(jum[0] + jum[1] + jum[2]) / 3.0;
    }

}

static class TestProgram
{
    public static void menu()
    {
        Console.WriteLine("--------------------------------------------------------");
        Console.WriteLine("메뉴 : 1.입력    2.조회    3.평균이상횟수    Q(q)");
        Console.WriteLine("--------------------------------------------------------\n");
    }
    public static void input(Emp[] n, int index)
    {
        n[index] = genInput(); //객체를 배열객체에 반환하는 인풋 메소드
        //Console.WriteLine("==========================================================");
        //return 타입이 Emp
    }
    public static Emp genInput() //새로운 객체에 입력을 받아 반환 하는 메소드
    {
        String name;
        int[] jum = new int[3];
        Console.Write("부서   :   ");
        name = Console.ReadLine();

        Console.WriteLine("==========================================================");
        Console.WriteLine("3분기 실적을 입력하세요");
        Console.WriteLine("==========================================================");

        for (int i = 0; i < 3; i++)
        {
            Console.Write("{0} : ", i + 1);
            jum[i] = int.Parse(Console.ReadLine());
        }


        Emp rt = new Emp(name, jum);
        Console.WriteLine("==========================================================\n");
        return rt;
    }

    public static void output(Emp[] n, int index) //출력메소드 
    {
        if (index == 0)
        {
            Console.WriteLine("ERROR: Array is empty");
            return;
        }
        Console.WriteLine("======================================================================");
        Console.WriteLine("{0,-10}      {1,-10}     {2,-10}     {3,-10}     {4,-10}", "부서", "1", "2", "3 분기", "평균");
        Console.WriteLine("======================================================================");
        for (int i = 0; i < index; i++)
        {

            n[i].show(); //배열의 index 번째 인덱스에서 출력 메소드 호출
        }

        Console.WriteLine("");

    }
    public static void avgAboveCount(Emp[] n, int index, ref int count)
    {
        Console.WriteLine("==========================================================");
        for (int i = 0; i < index; i++)
        {
            count = 0; //ref 로 참조할 매개변수 count를 초기화
            double tmp_avg = n[i].getAvg();
            for (int j = 0; j < 3; j++)
            {
                if (n[i][j] > tmp_avg) count++; //객체 배열 n[인덱스] 객체의 인덱서에 접근하여 평균보다 높으면 +1
            }
            Console.WriteLine("{0,-10}의 평균 {1,-10} 이상의 횟수 : {2,-10}", n[i].Name, n[i].getAvg().ToString("N2"), count);
        }
        Console.WriteLine("==========================================================");
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Emp[] x = new Emp[20];

        int index = 0, count = 0;

        while (true)
        {
            TestProgram.menu();
            Console.Write("메뉴 선택  :   ");
            string op = Console.ReadLine();
            //Console.WriteLine("--------------------------------------------------------");
            if (op == "1")
            {
                x[index] = new Emp(); //emp 객체  새로운 emp할당
                TestProgram.input(x, index); //static 입력 함수 (객체, 인덱스)
                x[index].com(); // Emp 형 객체 평균계산 메소드 실행
                ++index; //다음 객체로 이동
            }
            else if (op == "2")
            {
                TestProgram.output(x, index); //static 출력 : show() 호출

            }
            else if (op.Equals("3")) //static 평균 이상인 횟수 계산 함수
            {
                TestProgram.avgAboveCount(x, index, ref count);

            }
            else if (op == "Q" || op == "q" || index == 20)
            {
                Console.Write("프로그램 종료");
                return;
            }
            else { Console.WriteLine("잘못된 입력입니다."); }

        }
    }

}


/*
 test data form

영업1팀 23,14,28
영업2팀 17,23,69
영업3팀 23,52,68

 */