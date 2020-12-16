using System;

namespace _25
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m, i, j, k, l;
            int[] a = new int[100];
            int[] b = new int[100];
            int[] c = new int[200];
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());
            Console.Write("m= ");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti elementele primului vector:");
            for (i = 1; i <= n; i++)
                a[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti elementele celui de-al doilea vector:");
            for (i = 1; i <= m; i++)
                b[i] = int.Parse(Console.ReadLine());
            k = 1;
            i = 1;
            j = 1;
            while(i<=n && j<=m)
            {
                if(a[i]<b[j])
                {
                    k++;
                    c[k] = a[i];
                    i++;
                }
                else
                {
                    k++;
                    c[k] = b[j];
                    j++;
                }
            }
            if(i<=n)
            {
                for(l=i;l<=n;l++)
                {
                    k++;
                    c[k] = a[l];
                }
            }
            else
                for(l=j;l<=m;l++)
                {
                    k++;
                    c[k] = b[l];
                }
            for (i = 1; i <= k; i++)
                Console.Write("{0} ", c[i]);
        }
    }
}
