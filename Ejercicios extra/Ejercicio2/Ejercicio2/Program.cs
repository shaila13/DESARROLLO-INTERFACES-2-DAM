using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*EJERCICIO 2.  
Una vez visto como funcionan las estructuras condiconales, haz un programa en C# 
que sea capaz de pedir un Array de 5 números por consola y que al acabar
de pedirlos (uno a uno), muestre por pantalla la suma de los cinco elementos.
 */

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumaArray=0; //En c# hay que inicializar siempre las variables.
            int[] array = new int[5];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Escribe un número para elemento {0}: ", i+1);

                array[i] = UInt16.Parse(Console.ReadLine());
                sumaArray += array[i];
            }

            /*     for (int i = 0; i < array.Length; i++)
                 {
                     System.Console.WriteLine(array[i]); 
                 }

                 foreach (int numbers in array)
                 {
                
                 }*/
            System.Console.WriteLine("La suma del array es: "+sumaArray);
            // Keep the console window open in debug mode.
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();


        }
    }
}
