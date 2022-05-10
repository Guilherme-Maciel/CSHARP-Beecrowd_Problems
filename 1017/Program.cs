using System;

namespace _1017
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tem = double.Parse(Console.ReadLine());
            double vel = double.Parse(Console.ReadLine());
            double dis = vel * tem;

            double gasto = dis / 12;

            Console.WriteLine($"{gasto:F3}");
        }
    }
}
