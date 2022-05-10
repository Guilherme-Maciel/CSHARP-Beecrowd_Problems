using System;

namespace _1021
{
    internal class Program
    {
        static void Main(string[] args)
        {

                int cem, cinquenta, vinte, dez, cinco, dois, um, resto;
                double N;
                N = Double.Parse(Console.ReadLine());

                cem = (int)N / 100;
                double valor = N - (cem * 100);

                Console.WriteLine(valor);
                Console.WriteLine(cem + " nota(s) de R$ 100,00");

        }
    }
}

