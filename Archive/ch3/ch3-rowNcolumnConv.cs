using System;
//2차원 행렬 수정
class rowNcolumnConv
{
    public static void Main()
    {
        int[,] a = { { 1, 2, 3 }, { 4, 5, 6 } };
        //수정 전
        int size_x = a.GetLength(0);
        int size_y = a.GetLength(1);
        Console.WriteLine("Array Column, Row before modification : " + size_x + "," + size_y);

        //수정 전 배열 출력 메소드 호출
        print_array_2d(a);

        //수정
        a = Transpose(a, size_x, size_y);

        //수정 후
        size_x = a.GetLength(0);
        size_y = a.GetLength(1);
        Console.WriteLine("Array Column, Row After modification : " + size_x + "," + size_y);

        //수정 후 배열 출력
        print_array_2d(a);
    }
    static int[,] Transpose(int[,] input, int size_x, int size_y)
    {
        int[,] output = input; //매개변수 배열 복사
        output = new int[size_y, size_x]; //행과 열을 바꿔 새로운 배열 할당
        for (int i = 0; i < size_x; i++)
        {
            for (int j = 0; j < size_y; j++)
            {
                output[j, i] = input[i, j];
            }
        }
        //출력 배열 반환
        return output;
    }
    static void print_array_2d(int[,] input, string msg = "Print array") //2차원 배열 출력 
    {
        Console.WriteLine(msg);
        int size_x = input.GetLength(0);
        int size_y = input.GetLength(1);

        for (int i = 0; i < size_x; i++)
        {
            for (int j = 0; j < size_y; j++)
            {
                Console.Write(input[i, j] + " ");
            }
            Console.WriteLine();
        }

    }
}