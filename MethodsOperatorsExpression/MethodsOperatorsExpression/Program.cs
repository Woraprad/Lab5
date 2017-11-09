using System;

class Program
{
        static void Main()
    {
        int a;
        int b;
        Console.Write("Input Number:");
            a = Console.Read();

        b = mod(a);
        
        if (b == 1)
        {
            Console.WriteLine("Odd number");
        } 
        else
        {
            Console.WriteLine("even number");
        }
        Console.ReadKey();
    }

    static int mod(int a)
    {
        return a%2;
    }

}



