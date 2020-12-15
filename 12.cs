using System;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, aux, j;
            int[] v = new int[100];
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti elementele vectorului:");
            for (i = 0; i <= n - 1; i++)
                v[i] = int.Parse(Console.ReadLine());
            for (i = 0; i < n - 1; i++)
                for (j = i + 1; j < n; j++)
                    if (v[i] > v[j])
                    {
                        aux = v[i];
                        v[i] = v[j];
                        v[j] = aux;
                    }
            for (i = 0; i <= n - 1; i++)
                Console.Write("{0} ", v[i]);
        }
    }
}
