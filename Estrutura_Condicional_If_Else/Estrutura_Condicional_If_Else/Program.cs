using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrutura_Condicional_If_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com um número inteiro");
            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0) {
                Console.WriteLine("PAR!");
            }
            else {
                Console.WriteLine("IMPAR!");

                //COMPOSTA
            }

        }
       
    }
}


