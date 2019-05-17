using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Ingrese un numero: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{n} invertido: {Invertir(n)}");

        }

        public static int Invertir(int n)
        {
            int inv = 0;
            if (n == 0)
            {
                return n;
            }
            else
            {
                while (n > 0)
                {
                    inv = inv * 10 + (n % 10);
                    n = n / 10;
                }
                return inv;
            }
        }
    }
}
