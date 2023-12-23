using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosArgumentosEj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Numero;
            Console.WriteLine("Ingrese un valor para obtener sus multiplos del 0 al 10: ");
            Numero = int.Parse(Console.ReadLine());
            Console.WriteLine(string.Join(", ", Multiplicar(Numero)));
            Console.WriteLine("Presione una tecla para salir");
            Console.ReadKey();
        }

        static int[] Multiplicar(int Num)
        {
            int [] Resultado = new int[11];
            for (int i = 1; i <= 10; i++)
            {
                Resultado[i] = i * Num;
            }
            return Resultado;
        }
    }
}
