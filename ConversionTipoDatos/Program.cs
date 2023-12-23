using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace ConversionTipoDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Nombre;
            int Edad;
            bool Casado;
            double Sueldo;

            Console.Write("ingrese su nombre: ");
            Nombre = Console.ReadLine();
            Console.WriteLine("Saludos " + Nombre);

            Console.Write("ingrese su edad: ");
            Edad = int.Parse(Console.ReadLine());
            //Edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Edad + " de edad, genial");

            Console.Write("Eres casado? true o false: ");
            Casado = Convert.ToBoolean(Console.ReadLine());
            // Casado = bool.Parse(Console.ReadLine());
            Console.WriteLine("a las chicas les gustan los casados en " + Casado);

            Console.Write("ingresa tu sueldo: ");
            Sueldo = double.Parse(Console.ReadLine());
            // Sueldo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Sueldo + ", increible!");

            Console.ReadKey();
        }
    }
}
