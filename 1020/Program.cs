using System;

namespace _1020
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dias = Int32.Parse(Console.ReadLine());

            int anos = (int)dias / 365;
            dias = dias - (anos * 365);

            int meses = (int)dias / 30;
            dias = dias - (meses * 30);

            Console.WriteLine($"{anos} ano(s)");
            Console.WriteLine($"{meses} mes(es)");
            Console.WriteLine($"{dias} dia(s)");
        }
    }
}
