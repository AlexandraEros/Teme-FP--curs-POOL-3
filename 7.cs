using System;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, aux;
            int[] v = new int[100];
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti elementele vectorului:");
            for (i = 0; i <= n - 1; i++)
                v[i] = int.Parse(Console.ReadLine());
            for(i=0;i<=(n-1)/2;i++)
            {
                aux = v[i];
                v[i] = v[n-1-i];
                v[n-1-i] = aux;
            }
            for (i = 0; i <= n-1; i++)
                Console.Write("{0} ", v[i]);
        }
    }
}
