using System;

namespace _02_Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();

            p.Apresentar();
            p.Apresentar("Caio");
            p.Apresentar("Caio", 19);
        }
    }
}
