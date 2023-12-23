using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace EstructuraCiclicaDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Numero = 10;
            do
            {
                Console.WriteLine("Numero tiene un valor de: " +  Numero);
                Numero += 10;
            } while (Numero <= 50);
            Console.ReadKey();
        }
    }
}
