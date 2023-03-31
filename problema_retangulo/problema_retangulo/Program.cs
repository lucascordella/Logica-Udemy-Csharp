using System;
using System.Formats.Asn1;
using System.Globalization;
using static System.Math;
using System.Runtime.CompilerServices;

namespace problema_retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            double baseLength, height, area, perimeter, diagonal;

            Console.Write("Base do retangulo: ");
            baseLength = double.Parse(Console.ReadLine(), CI);
            Console.Write("Altura do retangulo: ");
            height = double.Parse(Console.ReadLine(), CI);

            area = baseLength * height;
            perimeter = 2 * (baseLength + height);
            diagonal = Sqrt((Pow(baseLength, 2.0)) + (Pow(height, 2.0)));

            Console.WriteLine("AREA = " + area.ToString("F4", CI));
            Console.WriteLine("PERIMETRO = " + perimeter.ToString("F4", CI));
            Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4", CI));
        }
    }
}