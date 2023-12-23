using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace EstructuraSelectiva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Dia;

            Console.WriteLine("si lunes es 1 y domingo 7, ingrese un numero para describir el dia actual entre 1 y 7: ");
            Dia = int.Parse(Console.ReadLine());

            switch (Dia)
            {
                case 1:
                    Console.WriteLine("Hoy es Lunes");
                    break;
                case 2:
                    Console.WriteLine("Hoy es Martes");
                    break;
                case 3:
                    Console.WriteLine("Hoy es Miercoles");
                    break;
                case 4:
                    Console.WriteLine("Hoy es Jueves");
                    break;
                case 5:
                    Console.WriteLine("Hoy es Viernes");
                    break;
                case 6:
                    Console.WriteLine("Hoy es Sabado");
                    break;
                case 7:
                    Console.WriteLine("Hoy es Domingo");
                    break;
                default:
                    Console.WriteLine("Quizas las instrucciones fueron muy complicadas, vuelve a intentarlo");
                    break;
            }
            Console.WriteLine("gracias por participar, presiona una tecla para finalizar");
            Console.ReadKey();
        }
    }
}
