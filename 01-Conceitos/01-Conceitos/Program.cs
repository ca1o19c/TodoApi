using System;

namespace _01_Conceitos
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Instanciar um objeto
            Pessoa p = new Pessoa();

            p.nome = "Caio";
            p.idade = 19;

            p.mensagem();
        }
    }
}
