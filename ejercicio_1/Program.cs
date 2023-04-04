using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese sus apellidos: ");
            string apellidos = Console.ReadLine();
            Console.Write("Ingrese su edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());
            Console.Write("Indique si sabe programar: ");
            string sabe_programar = Console.ReadLine();
            string mensaje = "Su nombre es " + nombre + " " + apellidos + ", tiene " + edad + " años y " + sabe_programar + " sabe programar.";
            Console.WriteLine(mensaje);
            Console.ReadKey();
        }
    }
}
