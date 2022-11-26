using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            double gr;
            string resp;

            do
            {
                Console.WriteLine("Deme angulo en grados: ");
                gr = double.Parse(Console.ReadLine());
                Console.WriteLine("Seno("+gr+") = "+seno(gr));
                Console.WriteLine("¿Otro angulo?");
                resp = Console.ReadLine();

            }while(resp != "no");
            Console.Read();
        }

        public static double factorial(int n)
        {
            double f,i;
            f = 1;
            for ( i = 1; i <= n; i++)
            {
                f = f * i;
            }
            return f;
        }

        public static double potencia (double x,int n)
        {
            double pot;
            int i;
            pot = 1;
            for (i = 1; i <=n; i++)
            {
                pot = pot * x;
            }
            return pot;
        }

        public static double seno(double gr)
        {
            double x, s;
            int i, n;

            x = gr * 3.141592 / 180;
            s = x;

            for (i = 2; i <=17 ; i++){
                n = 2 * i - i;
                if (i%2!=0){
                    s = s - potencia(x, n) / factorial(n);
                }
                else{
                   s = s + potencia(x, n) / factorial(n);
                }
            }
            return s;
        }
    }
}
