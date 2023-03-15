using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace Conversao_Implicita
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 2;

            double resultado = (double) a / b;


            Console.WriteLine(resultado);

            //Para fazer divisão de numeros inteiros é necessário incluir um casting
        }
    }
}
