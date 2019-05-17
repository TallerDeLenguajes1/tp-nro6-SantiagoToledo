using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            double n,a,b;
            Console.WriteLine("Ingrese un numero: ");
            n = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Valor absoluto: {Math.Abs(n)}");
            Console.WriteLine($"Cuadrado: {Math.Pow(n,2)}");
            Console.WriteLine($"Seno: {Math.Sin(n)}");
            Console.WriteLine($"Coseno: {Math.Cos(n)}");
            Console.WriteLine($"Parte entera: {Math.Floor(n)}");

            Console.WriteLine("Ingrese un numero: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese un numero: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Maximo: {Math.Max(a, b)}");
            Console.WriteLine($"Minimo: {Math.Min(a, b)}");
        }
    }
}
