using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Tercer_Parcial
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static int factorial(int n)
        {
            int f, i;
            f = 1;
            if (n==0)
            {
                return 1;
            }
            else
            {
                for ( i = 1;  i <= n;  i++)
                {
                    f = f * i;
                }
                return f;
            }
        }

    }
}
