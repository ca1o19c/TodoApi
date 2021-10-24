using System;

namespace Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            imprimeMensagem("Olá, mundo!");

            var nome = retornaNome("Caio", "Antonio");

            Console.WriteLine(nome);
        }

        static void imprimeMensagem(string msg)
        {
            Console.WriteLine(msg);
        }

        static string retornaNome(
            string nome,
            string sobrenome,
            int idade = 19
        )
        {
            string retorno = nome + " " + sobrenome + " tem " + idade;

            return retorno;
        }
    }
}