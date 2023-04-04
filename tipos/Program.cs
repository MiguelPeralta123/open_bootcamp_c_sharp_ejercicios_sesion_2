using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tipos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Coche
            int puertas = 4;
            int ruedas = 4;
            string marca = "Ford";
            bool itv_vigente = true;
            Console.WriteLine("El coche tiene " + puertas + " puertas, " + ruedas + " ruedas, es de la marca " + marca + " y el estado de la vigencia itv es " + itv_vigente);

            // Mesa
            float peso = 30.2f;
            float largo = 1.8f;
            string material = "madera";
            string color = "negro";
            Console.WriteLine("La mesa pesa " + peso + " kilos, mide " + largo + " metros, es de " + material + " y es de color " + color);
            Console.ReadLine();
        }
    }
}
