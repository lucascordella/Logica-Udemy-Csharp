using System;
using System.Globalization;
namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            double soma, media;
            int N, i;

            Console.Write("Quantos números você vai digitar? ");
            N = int.Parse(Console.ReadLine());

            double[] vet = new double[N];

            for(i = 0; i < N; i++)
            {
                Console.Write("Digite um número: ");
                vet[i] = double.Parse(Console.ReadLine(), CI);
            }

            Console.WriteLine();
            Console.Write("VALORES = ");
            for (i = 0; i < N; i++)
            {
                Console.Write(vet[i].ToString("F1", CI) + "  ");
            }

            soma = 0;
            for (i = 0; i < N; i++)
            {
                soma = soma + vet[i];
            }

            media = soma / N;

            Console.WriteLine();
            Console.WriteLine("SOMA = " + soma.ToString("F2", CI));
            Console.WriteLine("MEDIA = " + media.ToString("F2", CI));
        }
    }
}