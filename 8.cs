using System;

namespace _8
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
            int x = v[0];
            for (i = 1; i <= n - 1; i++)
                v[i - 1] = v[i];
            v[n - 1] = x;
            for (i = 0; i <= n - 1; i++)
                Console.Write("{0} ", v[i]);
        }
    }
}
