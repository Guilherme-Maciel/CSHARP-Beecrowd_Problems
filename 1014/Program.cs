using System;

namespace _1014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            double KMpL = x / y;

            Console.WriteLine($"{KMpL:F3} km/l");
        }
    }
}
