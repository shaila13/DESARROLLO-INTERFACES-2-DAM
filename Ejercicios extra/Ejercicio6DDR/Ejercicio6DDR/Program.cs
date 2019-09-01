using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//EJERCICIO 6
/* Pedir al usuario el precio de un producto (valor positivo) y la forma de pagar (efectivo o tarjeta) 
 * si la forma de pago es mediante tarjeta, pedir el numero de cuenta (inventado)*/
namespace Ejercicio6DDR
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Introduzca el precio del producto: ");
            double precio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Cómo va a pagar efectivo o tarjeta: ");
            string formaDePago = Console.ReadLine();

            switch (formaDePago.ToLower())
            {

                case "tarjeta":
                    Console.WriteLine("Introduzca su número de tarjeta:");
                    int pago = UInt16.Parse(Console.ReadLine());

                    Console.WriteLine("Pagado realizado. Gracias por su compra.");
                    break;
                case "efectivo":
                    Console.WriteLine("Ha pagado en efectivo. Gracias por su compra.");
                    break;

                default:
                    Console.WriteLine("No es correcto.");
                    break;
            }

            Console.ReadLine();
        }
    }
}
