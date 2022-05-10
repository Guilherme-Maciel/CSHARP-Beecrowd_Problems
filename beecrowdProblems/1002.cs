using System;

namespace beecrowdProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;
            double r, area;

            r = Convert.ToDouble(Console.ReadLine());

            area = r * r * pi;

            Console.WriteLine($"A={area:F4}");
        }
    }
}
