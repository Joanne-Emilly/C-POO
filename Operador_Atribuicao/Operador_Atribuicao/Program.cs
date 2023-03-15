using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operador_Atribuicao
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = a++;

            Console.WriteLine(a);
            Console.WriteLine(b);


            //++a primeiro incrementa a variavel "a", e depois atribui a "b" 
        }
    }
}
