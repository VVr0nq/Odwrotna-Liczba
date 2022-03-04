using System;

namespace zajecia_11._12
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int n, odwrotna = 0, a;
                Console.Write("Podaj liczbe ");
                n = int.Parse(Console.ReadLine());
                while (n != 0)
                {
                    a = n % 10;
                    odwrotna = odwrotna * 10 + a;
                    n /= 10;
                }
                Console.Write("Odwrotna Liczba: " + odwrotna);

            } 
        }
    }
}