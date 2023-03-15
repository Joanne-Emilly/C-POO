using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exe.SaidadeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "JOANNE";
           

            Console.WriteLine("Bom dia!");
            Console.WriteLine("Boa Tarde!"); 
            Console.WriteLine("Boa Noite!");
            Console.WriteLine(  "------------------------");
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture));


            // ToString serve para controlar a
            // quantidade de casas decimais.
            // CultureInfo.InvariantCulture serve para colcocar pontos em casas decimais
            // lembrar de incluir o system Globalization
        }
    }
}
