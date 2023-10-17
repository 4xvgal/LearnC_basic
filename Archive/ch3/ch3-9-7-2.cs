using System;

//ch3-9-7-2

// s = 1- (1/2) + (1/3) -(1/4) + ... - (1/10)

//loop 1 = +1
//loop 2 = -0.5 

class Program
{
    public static void Main(string[] args)
    {
        int destination = 10; //루프 횟수 선언

        double sum = 0;

        for (int i = 1; i <= destination; i++)
        {
            double n = (double)1 / i;
            if (i % 2 == 1) //홀수면 더하기 짝수면 빼기
            {
                sum += n;
                Console.WriteLine("loop : " + i + "    added:" + n + "    sum:" + sum);
            }
            else
            {
                sum -= n;
                Console.WriteLine("loop : " + i + "     odded:" + n + "    sum:" + sum);

            }

        }
        Console.WriteLine("\nfinal sum:" + sum);
    }
}