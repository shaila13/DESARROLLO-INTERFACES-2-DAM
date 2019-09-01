using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//EJERCICIO 9.
/*Recorre los números del 1 al 100. Muestra los números pares. Usar el tipo de bucle que quieras.*/
namespace Ejercicio9DDr
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Bucle while números pares.");

            int n = 1;
            while (n < 101)
            {
                if (n%2==0)
                {
                Console.WriteLine(n);
                }
                n++;
            }
            // Keep the console window open in debug mode.
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}
