using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encadeamento_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("QUAL A HORA ATUAL? ");
            int hora = int.Parse(Console.ReadLine());

           if (hora < 12) {
                Console.WriteLine("BOM DIA!");
            }
           else if (hora < 18) {
                Console.WriteLine("BOA TARDE!");
            } 
           else
            {
                Console.WriteLine("BOA NOITE!");
            }
        
        }
    }
}
