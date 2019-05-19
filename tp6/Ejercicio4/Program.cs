using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cadenas();  
            //Calculadora();
            Validacion();
         
        }

        public static void Cadenas()
        {
            string str1, str2, str3;
            
            Console.WriteLine("Ingrese una oracion 1: ");
            str1 = Console.ReadLine();
            Console.WriteLine("Ingrese una oracion 2: ");
            str2 = Console.ReadLine();
            Console.WriteLine("Ingrese una palabra: ");
            str3 = Console.ReadLine();
            Console.WriteLine($"Letras a: {str1.Substring(5)}");
            Console.WriteLine($"Longitud de str1: {str1.Length}");
            Console.WriteLine($"Concatena 1 y 2: {str1 + str2}");

            Console.WriteLine($"\n\"{str1}\" Escrita caracter por caracter: ");
            foreach (char c in str1)
            {
                Console.WriteLine($"{c}");
            }

            Console.WriteLine($"Ocurrencia \"{str3}\" en \"{str1}\": {str1.Contains(str3)}");
            Console.WriteLine($"\"{str1}\" en mayusculas:  {str1.ToUpper()}");
            Console.WriteLine($"\"{str1}\" en minusculas:  {str1.ToLower()}");
            Console.WriteLine($"Comparo str1 y str2:  {str1.CompareTo(str2)}");

            Console.WriteLine("Ingrese una oracion separada por -: ");
            str1 = Console.ReadLine();

            Console.WriteLine("Strings separados por -: ");
            string[] str4  = str1.Split('-');
            foreach(string a in str4)
            {
                Console.WriteLine($"\n {a}");
            }
           

        }

        public static void Calculadora()
        {
            string ecuacion;
            double res;
            Console.WriteLine("Ingrese una ecuacion: ");
            ecuacion = Console.ReadLine();


            char[] operadores = { '+', '-', '*', '/' };
            string[] operandos = ecuacion.Split(operadores);

            int posOperador = ecuacion.IndexOfAny(operadores);

            switch (ecuacion[posOperador])
            {
                case '+':
                    res = Convert.ToDouble(operandos[0]) + Convert.ToDouble(operandos[1]);
                    break;
                case '-':
                    res = Convert.ToDouble(operandos[0]) - Convert.ToDouble(operandos[1]);
                    break;
                case '*':
                    res = Convert.ToDouble(operandos[0]) * Convert.ToDouble(operandos[1]);
                    break;
                case '/':
                    res = Convert.ToDouble(operandos[0]) / Convert.ToDouble(operandos[1]);
                    break;
                default:
                    res = 0;
                    break;
            }

            Console.WriteLine($"{ecuacion} = {res}");
        }

        public static void Validacion()
        {

            Console.WriteLine("Ingrese una mail: ");
            string mail = Console.ReadLine();

            Console.WriteLine("Ingrese una direccion web: ");
            string web = Console.ReadLine();

            Console.WriteLine("{0} valido? :{1} ", mail, Regex.IsMatch(mail, @"\^[A-Za-z0-9_\.-]+@[A-Za-z0-9-]+\.[A-Za-z\.-]+\$"));
            Console.WriteLine("{0} valido? :{1} ", web, Regex.IsMatch(web, @"\^(http)?s?(//:)?(www.)?[A-Za-z0-9_-]+\.[A-Za-z_-]+\$"));
        }

    }
}
