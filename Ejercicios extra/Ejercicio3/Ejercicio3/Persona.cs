using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**EJERCICIO 3.  
Declara una clase 'Persona' con tres propiedades: nombre, apellidos y edad.
Crea un método en la clase persona que sirva para mostrar sus datos por consola (en forma
de texto) y otro que sirva para leer los datos desde la consola. Crea un Main (en otra clase),
 que llame primero al método de leer datos y que luego los muestre por pantalla, ayudado del
método de mostrar datos.  */


namespace Ejercicio3
{
    class Persona
    {
        // Field
        public string nombre;
        public string apellidos;
        public int edad;

        // Constructor Vacío
        public Persona()
        {

        }

        // Constructor
        public Persona(string nombre, string apellidos, int edad)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.edad = edad;
        }

        // Method
        public void ReadField()
        {
            Console.WriteLine("Introduzca un nombre: ");
            this.nombre = Console.ReadLine();
            Console.WriteLine("Introduzca los apellidoa: ");
            this.apellidos = Console.ReadLine();
            Console.WriteLine("Introduzca una edad: ");
            this.edad = UInt16.Parse(Console.ReadLine());

        }

        // Printing method:
        public void PrintPerson()
        {
            Console.WriteLine(nombre + " " + apellidos + ", tiene " + edad + " años.");
        }

    }




    }

