using System;

namespace _17
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, b, nb = 0, p = 1, r;
            Console.Write("n= ");
            n = int.Parse(Console.ReadLine());
            Console.Write("b= ");
            b = int.Parse(Console.ReadLine());
            while(n!=0)
            {
                r = n % b;
                n = n / b;
                nb = nb + r * p;
                p = p * 10;
            }
            Console.WriteLine(nb);
        }
    }
}
