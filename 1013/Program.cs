using System;

namespace _1013
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string linha = Console.ReadLine();
            String[] v = linha.Split(' ');

            int a = int.Parse(v[0]);
            int b = int.Parse(v[1]);
            int c = int.Parse(v[2]);

            int MaiorAB = (a + b + Math.Abs(a - b)) / 2;
            int Maior = (MaiorAB + c + Math.Abs(MaiorAB - c)) / 2;

            Console.WriteLine($"{Maior} eh o maior");
        }
    }
}
