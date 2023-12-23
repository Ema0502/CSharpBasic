using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstructuraCiclicaFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Numero;

            Console.WriteLine("Ingrese un Numero para conocer su multiplo del 0 al 10");
            Numero = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(Numero + " x " + i + "=" + (Numero * i));
            }
            Console.WriteLine("Presione una tecla para finalizar");
            Console.ReadKey();
        }
    }
}
