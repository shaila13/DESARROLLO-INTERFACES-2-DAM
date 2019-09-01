using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//EJERCICIO 1. 
/*
 * Crear 3 variables numéricas con el valor que tu quieras y en otra variable numérica guardar el valor de la suma
 */
namespace Ejercicio1DDR
{
    class Program
    {
        static void Main()
        {
            int num1 = 3; int num2 = 5; int num3 = 6;
            int sumaArray = 0; //En c# hay que inicializar siempre las variables.
            sumaArray = num1 + num2 + num3;

            System.Console.WriteLine("La suma es: " + sumaArray);
            // Keep the console window open in debug mode.
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();

        }
    }
}
