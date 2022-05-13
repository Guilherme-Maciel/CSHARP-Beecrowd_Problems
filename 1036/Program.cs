using System;

namespace _1036
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

            if (a != 0)
            {
                double delta = (b * b) - 4 * a * c;
                if (delta >= 0)
                {
                    delta = Math.Sqrt(delta);
                    double x1 = (-b + delta) / (2 * a);
                    double x2 = (-b - delta) / (2 * a);

                    Console.WriteLine($"R1 = {x1:F5}");
                    Console.WriteLine($"R2 = {x2:F5}");
                }
                else
                {
                    Console.WriteLine("Impossivel calcular");
                }

            }
            else
            {
                Console.WriteLine("Impossivel calcular");
            }

        }
    }
}
