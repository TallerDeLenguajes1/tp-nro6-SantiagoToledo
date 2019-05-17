using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora();
        }

        public static void Calculadora()
        {
            int a, b, res = 0, menu = 5;
            while (menu != 0)
            {
                Console.WriteLine("Calculadora: \n 1-Sumar \n 2-Restar \n 3-Multiplicar \n 4-Dividir");
                menu = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Inrgrese el primer numero: ");
                a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Inrgrese el segundo numero: ");
                b = Convert.ToInt32(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        res = a + b;
                        break;
                    case 2:
                        res = a - b;
                        break;
                    case 3:
                        res = a * b;
                        break;
                    case 4:
                        res = a - b;
                        break;
                    default:
                        Console.WriteLine("No se ingreso una opcion valida");
                        break;
                }

                Console.WriteLine("\nResultado: {0}", res);
                Console.WriteLine("\nIngrese 5 para realizar otra operacion, 0 para salir");
                menu = Convert.ToInt32(Console.ReadLine());
            }

        }
    }
}
