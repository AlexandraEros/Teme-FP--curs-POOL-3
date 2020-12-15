using System;

namespace _16
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, a, b, r;
            int[] v = new int[100];
            Console.WriteLine("Cate elemente are vectorul?");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti primul element:");
            a = int.Parse(Console.ReadLine());
            for (i = 1; i <= n-1; i++)
            {
                Console.WriteLine("Introduceti urmatorul element:");
                b = int.Parse(Console.ReadLine());
                while (b!=0)
                {
                    r = a % b;
                    a = b;
                    b = r;
                }
            }
            Console.WriteLine(a);
        }
    }
}
