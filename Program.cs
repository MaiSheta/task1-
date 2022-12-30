using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, a, b, i;
            Console.WriteLine("please enter n1");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter n2");
            n2 = int.Parse(Console.ReadLine());
            for (i = n1; i <= n2; i++)
            {
                a = 1;
                b = 0;
                while (i > a)
                {
                    if (i % a == 0)
                        b = b + a;
                    a++;
                }
                if (b == i)
                    Console.WriteLine("{0}", i);

            }
    }
}




    