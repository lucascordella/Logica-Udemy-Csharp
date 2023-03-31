using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int N, i, j, soma;

            Console.Write("Qual a ordem da matriz? ");
            N = int.Parse(Console.ReadLine());

            int[,] mat = new int[N, N];

            for (i = 0; i < N; i++)
            {
                for(j = 0; j < N; j++)
                {
                    Console.Write("Elemento [" + i + "," + j + "]: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("DIAGONAL PRINCIPAL:");
            for (i = 0; i < N; i++)
            {
                for (j = 0; j < N; j++)
                {
                    if (i == j)
                    {
                        Console.Write(mat[i, j] + " "); 
                    }
                }
            }

            Console.WriteLine();
            soma = 0;
            for (i=0; i < N; i++)
            {
                for (j = 0; j < N; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        soma = soma + 1;
                    }
                }
            }

            Console.WriteLine("QUANTIDADE DE NEGATIVOS = " + soma);
        }
    }
}
