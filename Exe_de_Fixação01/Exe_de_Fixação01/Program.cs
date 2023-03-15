using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace Exe_de_Fixação01
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de Escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("PRODUTOS:");

            Console.WriteLine("{0}, cujo preço é R$ {1}. ", produto1, preco1);
            Console.WriteLine("{0}, cujo preço é R$ {1}. ", produto2, preco2);

            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Registro: {0} anos de idade, o código é {1} e genero {2}", idade, codigo, genero);
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Medida com oito casas decimais: {0}", medida);
            Console.WriteLine($"Arredondamento: (três casas decimais) {medida:F3}");
            Console.WriteLine("Separador decimal Invariant Culture:" + medida.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
