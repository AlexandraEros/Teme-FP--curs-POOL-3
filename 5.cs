using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k, e, i;
            int[] v = new int[100];
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());
            Console.Write("e= ");
            e = int.Parse(Console.ReadLine());
            Console.Write("k= ");
            k = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti elementele vectorului: ");
            for (i = 0; i <= n-1 ; i++)
                v[i] = int.Parse(Console.ReadLine());
            for (i = n - 1; i >= k+1 ; i--)
                v[i + 1] = v[i];
            v[k+1] = e;
            for (i = 0; i <= n-1 ; i++)
                Console.Write("{0} ", v[i]);
        }
    }
}
