using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Jugadores = { "Messi", "Dibu", "Hazard" };

            for (int i = 0; i < Jugadores.Length; i++)
            {
                Console.WriteLine("El jugador del vector en el indice " + i + " es " + Jugadores[i]);
            }
            Console.ReadKey();
        }
    }
}
