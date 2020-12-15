using System;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            int[] v = new int[100];
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti elementele vectorului:");
            for (i = 0; i <= n - 1; i++)
                v[i] = int.Parse(Console.ReadLine());
            for (i = 1; i < n; i++)
            {
                int x = v[i];
                int p = i - 1;
                while (p >= 0 && v[p] > x)
                {
                    v[p + 1] = v[p];
                    p--;
                }
                v[p + 1] = x;
            }
            for (i = 0; i <= n - 1; i++)
                Console.Write("{0} ", v[i]);

        }
    }
}
