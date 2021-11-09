using System;

namespace _07_Construtor
{
    class Filme
    {
        public Filme()
        {
            Console.WriteLine("Construtor executado");
        }

        public Filme(string titulo)
        {
            Console.WriteLine("Construtor com parametro! o valor é " + titulo);
        }
    }
}
