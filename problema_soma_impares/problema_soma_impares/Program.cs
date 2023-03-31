using System;
using System.Globalization;
namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int X, Y, i, soma, troca;

            Console.WriteLine("Digite dois números: ");
            X = int.Parse(Console.ReadLine());
            Y = int.Parse(Console.ReadLine());

            if (X > Y)
            {
                troca = X;
                X = Y;
                Y = troca;
            }

            soma = 0;
            for (i = X + 1; i < Y; i++)
            {
                if (i % 2 != 0)
                {
                    soma = soma + i;
                }
            }

            Console.WriteLine("SOMA DOS IMPARES = " + soma);

        }
    }
}