using System;

namespace _1011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raio, volume, pi = 3.14159;
            raio = double.Parse(Console.ReadLine());

            volume = (4.0 / 3.0) * pi * (raio * raio * raio);

            Console.WriteLine($"VOLUME = {volume:F3}");
        }
    }
}
