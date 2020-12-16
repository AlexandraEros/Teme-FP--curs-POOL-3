using System;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, k, x;
            int[] v = new int[100];
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());
            Console.Write("k= ");
            k = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti elementele vectorului:");
            for (i = 1; i <= n; i++)
                v[i] = int.Parse(Console.ReadLine());
            for (k = 1; k <= n; k++)
            {
                x = v[1];
                for (i = 2; i <= n; i++)
                    v[i - 1] = v[i];
                v[n] = x;
                for (i = 1; i <= n; i++)
                    Console.Write("{0} ", v[i]);
                Console.WriteLine();
            }
        }
    }
}
