using System;


namespace ProgramaTexto1
{
    class Program
    {
        static void Main(string[] args)
        {
            string c, c1, d, d1;

            Console.Write("\n Digite a palavra 1: ");
            c = Console.ReadLine();
            Console.Write("\n Digite a palavra 2: ");
            c1 = Console.ReadLine();
            Console.Write("\n Tamanho da 1 palavra: {0}, c.Length ");
            Console.Write("\n concatenando sem armazenar: {0}", c + c1);
            d = c;
            Console.Write("\n o conteúdo de d: {0}", d);
            d1 = c + c1;
            Console.Write("\n concatenação: {0}", d1);
            Console.Write("\n primeiro caractere: {0}", c.Substring(0, 1));
            Console.Write("\n Último caractere: {0}", c.Substring(c1.Length - 1, 1));
            Console.Write("\n todos menos o primeiro: {0}", c.Substring(1));
            Console.Write("\n o terceiro elemento: {0}", c.Substring(4, 1));  //5° caractere
            Console.Write("\n os três primeiros eleentos: {0}", c.Substring(0, 3));
            Console.Write("\n os três ultimos elementos: {0}", c1.Substring(c1.Length - 3, 3));
        }
    }
}
