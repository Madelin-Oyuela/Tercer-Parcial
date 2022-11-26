using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, numero;
            Console.Write("Deme un numero entero y positivo: ");
            numero = int.Parse(Console.ReadLine());
            x = factorial(numero);
            y = factorial(5);
            Console.WriteLine("x= "+x+"\ny= "+y);
            Console.ReadLine();
        }

         public static int factorial(int n){
            int i, f;
            f = 1;

            for  (i = 1; i <= n; i++)
            {
                f = f * i;
            }
            return f;
        }
    }
}
