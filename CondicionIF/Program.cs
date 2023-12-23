using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondicionIF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Nombre;
            double Sueldo;

            Console.WriteLine("Ingrese su nombre: ");
            Nombre = Console.ReadLine();
            Console.WriteLine("Saludos " + Nombre);

            Console.WriteLine("Ingrese su sueldo de programador en argentina valuado en dolares: ");
            Sueldo = Convert.ToDouble(Console.ReadLine());
            if (Sueldo < 1000)
            {
                Console.WriteLine(Nombre + ", su sueldo es bajo para el promedio");
            } 
            else if (Sueldo >= 1000 && Sueldo < 3500)
            {
                Console.WriteLine(Nombre + ", su sueldo esta en el promedio correcto");
            } 
            else
            {
                Console.WriteLine(Nombre + " tiene un gran sueldo, que bueno");
            }
            Console.WriteLine("Presione una tecla para salir");
            Console.ReadKey();
        }
    }
}
