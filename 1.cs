using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, s = 0;
            int[] v = new int[100];
            Console.Write("Cate numere contine vectorul? ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti elementele vectorului de la tastatura:");
            for (i = 0; i <= n - 1; i++)
                v[i] = int.Parse(Console.ReadLine());
            for(i=0;i<=n-1;i++)
            {
                s = s + v[i];
            }
            Console.WriteLine("Suma elementelor vectorului este: {0}", s);
        }
    }
}
