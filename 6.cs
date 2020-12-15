using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k, i;
            int[] v = new int[100];
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());
            Console.Write("k= ");
            k = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti elementele vectorului:");
            for (i = 0; i <= n - 1; i++)
                v[i] = int.Parse(Console.ReadLine());
            for (i = k; i <= n - 2; i++)
                v[i] = v[i + 1];
            n--;
            for(i=0;i<=n-1;i++)
               Console.Write("{0} ", v[i]);
        }
    }
}
