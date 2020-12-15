using System;

namespace _28
{
    public static int pozitie(int st, int dr)
    {
        int[] v = new int[100];
        int i = st, j = dr, di = 0, dj = 1, aux;
        while(i<j)
        {
            if(v[i]>v[j])
            {
                aux = v[i];
                v[i] = v[j];
                v[j] = aux;
                aux = di;
                di = dj;
                dj = aux;
            }
            i = i + di;
            j = j - dj;
        }
        return i;
    }
    public static void quicksort(int st,int dr,int [] v,int n)
    {
        if(st<dr)
        {
            int p = pozitie(st, dr);
            quicksort(st, p - 1, v, n);
            quicksort(p + 1, dr, v, n);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            int[] v = new int[100];
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti elementele vectorului: ");
            for (i = 0; i <= n - 1; i++)
                v[i] = int.Parse(Console.ReadLine());
            quicksort(0, n - 1, v, n);
            for (i = 0; i <= n - 1; i++)
                Console.WriteLine(v[i]);
        }
    }
}
