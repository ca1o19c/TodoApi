using System;

namespace _10_Heranca
{
    class Pessoa
    {
        protected string nome;
        protected int idade;

        protected string Nome { get => nome; set => nome = value; }
        protected int Idade { get => idade; set => idade = value; }

        protected void MensagemPessoa()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Idade: " + Idade);
        }
    }
}
