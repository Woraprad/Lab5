using System;

class Program
{
        static void Main()
    {
        int a;
        int b;
        int c;
   
        Console.Write("Input First Number:");
        a = Convert.ToInt32( Console.ReadLine());
        Console.Write("Input Last Number:");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Divisible number 7:");

        for (int i = a; i <= b; i++)   
        {
            c = mod(i);

            if (c == 0)
            {
                Console.WriteLine(i);
            }
            
        }
        Console.ReadKey();
    }

    static int mod(int x)
    {
        return x%7;
    }

}



