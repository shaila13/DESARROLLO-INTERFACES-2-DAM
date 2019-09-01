using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//EJERCICIO 2
/*
 * Pedir nombre y ciudad por consola y mostrar Hola --- bienvenido a ---
 */
namespace Ejercicio2DDR
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Introduzca su nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Introduzca su ciudad: ");
            string ciudad = Console.ReadLine();

            Console.WriteLine("Hola " + nombre + ", bienvenido a " + ciudad);

            // Keep the console window open in debug mode.
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();

        }
    }
}
