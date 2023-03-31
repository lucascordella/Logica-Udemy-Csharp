using System;
using System.Globalization;
namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int N1, N2, N3, menor;

            Console.Write("Primeiro valor: ");
            N1 = int.Parse(Console.ReadLine());
            Console.Write("Segundo valor: ");
            N2 = int.Parse(Console.ReadLine());
            Console.Write("Terceiro valor: ");
            N3 = int.Parse(Console.ReadLine());

            menor = N1;
            if (menor > N2)
            {
                menor = N2;
            }
            if (menor > N3)
            {
                menor = N3;
            }

            Console.Write("MENOR = " +  menor);
        }
    }
}