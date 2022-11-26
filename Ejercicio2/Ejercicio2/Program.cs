using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = cubo(2);
            Console.WriteLine("2 al cubo es: "+n);
            Console.WriteLine("3 al cubo es: " + cubo(3));
            Console.ReadLine();
        }

        public static int cubo(int x)
        {
            return x * x * x;
        }
    }
}
