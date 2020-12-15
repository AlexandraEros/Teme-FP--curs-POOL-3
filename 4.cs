using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, maxim=0, minim=0, kmax = 0, kmin = 0;
            int[] v = new int[100];
            Console.WriteLine("Cate elemente contine vectorul?");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti elementele vectorului:");
            for (i = 0; i <= n - 1; i++)
                v[i] = int.Parse(Console.ReadLine());
            maxim = minim = v[0];
            for (i = 0; i <= n - 1; i++)
            {
                if (v[i] > maxim)
                    maxim = v[i];
                if (v[i] < minim)
                    minim = v[i];
            }
            for (i = 0; i <= n - 1; i++)
            { if (v[i] == maxim)
                    kmax++;
                if (v[i] == minim)
                    kmin++;
            }
            Console.WriteLine("Valoarea maxima din vector este {0} si se gaseste de {1} ori", maxim, kmax);
            Console.WriteLine("Valoarea minima din vector este {0} si se gaseste de {1} ori", minim, kmin);
        }
    }
}
