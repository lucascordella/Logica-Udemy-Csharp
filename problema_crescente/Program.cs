using System;
using System.Globalization;
namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int X, Y;

            Console.WriteLine("Digite dois números:");
            X = int.Parse(Console.ReadLine());
            Y = int.Parse(Console.ReadLine());

            while (X != Y)
            {
                if (X < Y)
                {
                    Console.WriteLine("CRESCENTE!");
                }
                else
                {
                    Console.WriteLine("DESCRESCENTE!");
                }

                Console.WriteLine("Digite outros dois números:");
                X = int.Parse(Console.ReadLine());
                Y = int.Parse(Console.ReadLine());
            }
        }
    }
}