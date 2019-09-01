using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//EJERCICIO 7
/* Recorre los números del 1 al 100. Usa un bucle for.*/
//EJERCICIO8
/*Recorre los números del 1 al 100. Usa un bucle while.*/
namespace Ejercicio7DDR
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Bucle for.");
          for (int i = 1; i < 101; i++)
     {
         System.Console.WriteLine(i); 
     }
          System.Console.WriteLine("Bucle while.");
            
          int n = 1;
          while (n < 101)
          {
              Console.WriteLine(n);
              n++;
          }
            // Keep the console window open in debug mode.
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();

        }






    }
}
