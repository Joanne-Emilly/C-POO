using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores_Aritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 1.0, b = -3.0, c = -4.0;

            double delta = b * b - 4 * a * c;

            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a); 




            Console.WriteLine(delta);
            Console.WriteLine(x1);
            Console.WriteLine(x2);
            //Math.Pow(b, 2.0) = b*b = b ao quadrado
            //Math.Sqrt RAIZ QUADRADA



        }
    }
}
