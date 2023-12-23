using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresLogicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            a = 10;
            b = 3;
            c = 305;
            d = 0;
            
            Console.WriteLine((a + b == 13) || (d == 0));
            Console.WriteLine((a + b == 13) && (d < 0));
            Console.WriteLine(!(a+b == b-c));
            Console.ReadKey();
        }
    }
}
