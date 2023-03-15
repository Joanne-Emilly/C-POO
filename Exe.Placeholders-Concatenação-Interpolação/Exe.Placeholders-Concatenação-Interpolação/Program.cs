using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exe.Placeholders_Concatenação_Interpolação
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 29;
            double saldo = 10000.00;
            string nome = "JOANNE";

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais: PLACEHOLDERS ", nome, idade, saldo);
            //PLACEHOLDERS

            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais: INTERPOLANDO");
            //Interpolação

            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", (CultureInfo.InvariantCulture)) + " reais: CONCATENANDO  ");
            //Concatenação

        }
    }  
}
