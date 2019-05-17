using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1, str2, str3;
            Console.WriteLine("Ingrese una oracion 1: ");
            str1 = Console.ReadLine();
            Console.WriteLine("Ingrese una oracion 2: ");
            str2 = Console.ReadLine();
            Console.WriteLine("Ingrese una palabra: ");
            str3 = Console.ReadLine();
            Console.WriteLine($"Letras a: {str1.Substring(5)}");
            Console.WriteLine($"Longitud: {str1.Length}");
            Console.WriteLine($"Concatena 1 y 2: {str1 + str2}");

            foreach(char c in str1)
            {
                Console.WriteLine($" {c} ");
            }

            Console.WriteLine($"Ocurrencia {str3}: {str1.Contains(str3)}");
            Console.WriteLine($"Mayusculas:  {str1.ToUpper()}");
            Console.WriteLine($"Minusculas:  {str1.ToLower()}");
        }
    }
}
