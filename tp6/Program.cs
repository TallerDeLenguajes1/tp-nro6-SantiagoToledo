using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1893;
            Console.WriteLine($"{n} invertido: {Invertir(n)}");

            Calculadora();

        }

        public static int Invertir(int n)
        {
            int inv = 0;
            if (n==0)
            {
                return n;
            }
            else { 
                while (n>0)
                {
                    inv = inv*10 + (n % 10);
                    n = n / 10;
                }
                return inv;
            }
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

        public static void Cadenas()
        {
            string a, b; 
            Console.WriteLine("Ingrese una cadena: ");
            a = Console.ReadLine();

        }
    }
}
