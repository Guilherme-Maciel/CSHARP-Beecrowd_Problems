using System;

namespace _1012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string linha = Console.ReadLine();
            String[] v = linha.Split(' ');

            double a = double.Parse(v[0]);
            double b = double.Parse(v[1]);
            double c = double.Parse(v[2]);
            double pi = 3.14159;

            double Qa = (a * c) / 2;
            double Qb = (c * c) * pi;
            double Qc = ((a + b) * c) / 2;
            double Qd = b * b;
            double Qe = a * b;

            Console.WriteLine($"TRIANGULO: {Qa:F3}");
            Console.WriteLine($"CIRCULO: {Qb:F3}");
            Console.WriteLine($"TRAPEZIO: {Qc:F3}");
            Console.WriteLine($"QUADRADO: {Qd:F3}");
            Console.WriteLine($"RETANGULO: {Qe:F3}");
        }
    }
}
