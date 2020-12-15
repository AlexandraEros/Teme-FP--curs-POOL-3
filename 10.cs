using System;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, ok = 0, mij, st = 0, k, i;
            int[] v = new int[100];
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());
            int dr = n - 1;
            Console.Write("k= ");
            k = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti elementele vectorului:");
            for (i = 0; i <= n - 1; i++)
                v[i] = int.Parse(Console.ReadLine());
            while(ok==0 && st<=dr)
            {
                mij = (st + dr) / 2;
                if (k == v[mij])
                {
                    ok = 1;
                    Console.WriteLine("Am gasit elementul pe pozitia {0}", mij);
                }
                else
                    if (k > v[mij])
                    st = mij + 1;
                else
                    dr = mij - 1;
            }
            if (ok == 0)
                Console.WriteLine(-1);
        }
    }
}
