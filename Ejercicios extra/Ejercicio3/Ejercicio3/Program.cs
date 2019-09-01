using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main()
        {

            Persona person = new Persona("Shaila","Pérez Fernández",34);
            System.Console.WriteLine(person.nombre);

            person.ReadField(); person.PrintPerson();
            // Keep the console window open in debug mode.
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}
