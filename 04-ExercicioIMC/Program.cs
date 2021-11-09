using System;

namespace _04_ExercicioIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();

            p.altura = 1.70;
            p.peso = 90;

            p.Mensagem();
        }
    }
}
