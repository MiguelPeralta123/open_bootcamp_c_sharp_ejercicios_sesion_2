using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(numero + " es mayor o igual a 18: " + (numero >= 18));
            Console.Write("Ingrese un caracter: ");
            char caracter = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("'" + caracter + "' es igual a 'a': " + (caracter == 'a'));
            bool condicion1 = true;
            bool condicion2 = false;
            Console.WriteLine(condicion1 + " y " + condicion2 + ": " + (condicion1 && condicion2));
            Console.WriteLine(condicion1 + " o " + condicion2 + ": " + (condicion1 || condicion2));
        }
    }
}
