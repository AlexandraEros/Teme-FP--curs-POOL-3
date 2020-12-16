using System;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, j;
            int[] v = new int[1000];
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());
            for (i = 0; i <= n; i++)
                v[i] = 0;
            v[0] = v[1] = 1;
            for (i = 2; i * i <= 100; i++)
                if (v[i] == 0)
                    for (j = i * i; j <= 100; j = j + i)
                        v[j] = 1;
            for (i = 0; i <= n; i++)
                if (v[i] == 0)
                    Console.Write("{0} ", i);
        }
    }
}
