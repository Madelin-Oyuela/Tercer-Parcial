using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Tercer_Parcial_Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(mcd(5,60));
            Console.Read();
        }

        public static int mcd(int a,int b)
        {
            while (a!=b)
            {
                if (a>b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            return a;
        }
    }
}
