using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2,i,j,flag;
            Console.WriteLine("please enter n1");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter n2");
            n2 = int.Parse(Console.ReadLine());
            for (i = n1; i <= n2; i++)
            {
                for (j = 2; j <= i / 2; i++)
                {
                    if (i % j == 0)
                    {
                        Flag = 0;
                        break;
                    }
                }
            }
    }
}
