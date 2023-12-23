using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] Nombres = new string[2, 3];
            Nombres[0, 0] = "Luis";
            Nombres[0, 1] = "Ana";
            Nombres[0, 2] = "Ken";
            Nombres[1, 0] = "Terry";
            Nombres[1, 1] = "Eden";
            Nombres[1, 2] = "Saori";

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("la posicion actual es: " + i + j + " y el nombre es: " + Nombres[i,j]);
                }
            }
            Console.ReadKey();
        }
    }
}
