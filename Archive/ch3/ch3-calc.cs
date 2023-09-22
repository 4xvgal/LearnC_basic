using System;

class Calc
{
    public static void Main()
    {
        int x, y, o = 0;
        char opr;

        Console.WriteLine("Enter an operator & two numbers");

        opr = (char)Console.Read();

        x = Console.Read() - '0';
        y = Console.Read() - '0';
        switch (opr)
        {
            case '+':
                o = x + y;
                Console.WriteLine(x + " +" + y + " =" + o);
                break;
            case '-':
                o = x - y;
                Console.WriteLine(x + " -" + y + " =" + o);
                break;
            case '*':
                o = x * y;
                Console.WriteLine(x + " *" + y + " =" + o);
                break;
            case '/':
                o = x / y;
                Console.WriteLine(x + " /" + y + " =" + o);
                break;
        }
    }
}