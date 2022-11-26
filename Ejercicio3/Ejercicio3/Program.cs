using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            double g;

            Console.Write("Deme angulo en grados: ");
            g = double.Parse(Console.ReadLine());
            Console.WriteLine(seno(g));
            Console.WriteLine(coseno(g));
            Console.Read();
        }

        public static double coseno(double g)
        {
            return Math.Cos(g * 2 * 3.131592 / 360);
        }

        public static double seno(double g)
        {
            return Math.Sin(g * 2 * 3.131592 / 360);
        }
    }
}
