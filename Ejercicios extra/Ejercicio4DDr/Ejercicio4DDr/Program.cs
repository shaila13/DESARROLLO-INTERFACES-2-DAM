using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//EJERCICIO 4
/*Pedir dos números al usuario por teclado y decir que número es el mayor.*/
namespace Ejercicio4DDr
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Introduzca un número: ");
            int num = UInt16.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Introduzca un número: ");
            int num1 = UInt16.Parse(Console.ReadLine());

            if (num > num1)
            {
                Console.WriteLine(num + " es mayor que " + num1);
            }
            else if (num < num1)
            {
                Console.WriteLine(num1 + " es mayor que " + num);
            }else
            {
                Console.WriteLine("Ambos números son iguales." );
            }

            // Keep the console window open in debug mode.
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();

        }
    }
}
