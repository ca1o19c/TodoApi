using System;

namespace _08_GetSet
{
    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new Carro();

            c1.Nome = "Fiat Mobi";
            c1.Ano = 2022;

            Console.Write(c1.Nome + " ");
            Console.WriteLine(c1.Ano);
        }
    }
}
