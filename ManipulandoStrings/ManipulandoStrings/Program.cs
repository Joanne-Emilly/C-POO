using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulandoStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = "Universidade Paulista";
            Console.WriteLine("A frase {0} possui {1}, caracteres", frase, frase.Length);
            Console.WriteLine("Seus três primeiros caracteres são {0}", frase.Substring(0, 3));
            Console.WriteLine("Os seus três ultimos caracteres são {0}", frase.Substring(frase.Length- 4, 4));


            Console.ReadKey();
        }
    }
}
