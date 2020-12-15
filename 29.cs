using System;

namespace _29
{
    class Program
    {
        public static void interclasare(int [] v,int st,int p,int dr)
        {
            int i = st, j = p + 1, k = 1;
            int[] u = new int[100];
            while(i<=p && j<=dr)
            {
                if(v[i]<v[j])
                {
                    u[k] = v[i];
                    k++;
                    i++;
                }
                else
                {
                    u[k] = v[j];
                    k++;
                    j++;
                }
            }
            while(i<=p)
            {
                u[k] = v[i];
                k++;
                i++;
            }
            while(j<=dr)
            {
                u[k] = v[j];
                k++;
                j++;
            }
            int t = st;
            for(k=1;k<=(dr-st)+1;k++)
            {
                v[t] = u[k];
                t++;
            }
        }
        public static void mergesort(int st,int dr)
        {
            int[] v = new int[100];
            if(st<dr)
            {
                int mij = (st + dr) / 2;
                mergesort(st, mij);
                mergesort(mij + 1, dr);
                interclasare(v, st, mij, dr);
            }
        }
        static void Main(string[] args)
        {
            int n, i;
            int[] v = new int[100];
            Console.WriteLine("n= ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti elementele vectorului:");
            for (i = 0; i <= n - 1; i++)
                v[i] = int.Parse(Console.ReadLine());
            mergesort(0, n-1);
            for (i = 0; i <= n - 1; i++)
                Console.Write("{0} ",v[i]);
        }
    }
}
