using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, maxim, minim, pozmax=0, pozmin=0;
            int[] v = new int[100];
            Console.WriteLine("Cate elemente contine vectorul?");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti elementele vectorului:");
            for (i = 0; i <= n - 1; i++)
                v[i] = int.Parse(Console.ReadLine());
            maxim = minim = v[0]; //initializam maximul si minimul cu primul element al vectorului
            for(i=0;i<=n-1;i++)
            {
                if(v[i]>maxim)
                {
                    maxim = v[i];
                    pozmax = i;
                }
                if(v[i]<minim)
                {
                    minim = v[i];
                    pozmin = i;
                }
            }
            Console.WriteLine("Minimul se afla pe pozitia {0},iar maximul se afla pe pozitia {1} in vector", pozmin, pozmax);
        }
    }
}
