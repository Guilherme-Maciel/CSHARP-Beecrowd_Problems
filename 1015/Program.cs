using System;

namespace _1015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string linha1 = Console.ReadLine();
            String[] v1 = linha1.Split(' ');
            double x1 = double.Parse(v1[0]);
            double y1 = double.Parse(v1[1]);

            string linha2 = Console.ReadLine();
            String[] v2 = linha2.Split(' ');
            double x2 = double.Parse(v2[0]);
            double y2 = double.Parse(v2[1]);

            double dis = ((x2 - x1) * (x2 - x1)) + ((y2 - y1)*(y2 - y1));

            dis = (double)Math.Sqrt(dis);

            Console.WriteLine($"{dis:F4}");
        }
    }
}
