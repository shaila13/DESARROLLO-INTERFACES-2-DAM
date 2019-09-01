using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//EJERCICIO 3
/*
 * Pedir nombre y edad por consola y mostrar Te llamas --- y tienes --- años.
 */
namespace Ejercicio3DDR
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Introduzca su nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Introduzca su edad: ");
            int edad = UInt16.Parse(Console.ReadLine());

            Console.WriteLine("Te llamas " + nombre + ",  y tienes " + edad+" años.");
            // Keep the console window open in debug mode.
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}
