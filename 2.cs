using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, k, ok = 0;
            int[] v = new int[100];
            Console.WriteLine("Cate elemente contine vectorul?");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("k=");
            k = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti elementele vectorului:");
            for (i = 0; i <= n - 1; i++)
                v[i] = int.Parse(Console.ReadLine());
            for (i = 0; i <= n - 1; i++)
                if (v[i] == k)
                {
                    Console.WriteLine(i);
                    ok = 1;
                    break;
                }
            if (ok == 0)
                Console.WriteLine(-1);
        }
    }
}
