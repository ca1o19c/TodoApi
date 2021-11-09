using System;

namespace _10_Heranca
{
    class Colaborador : Pessoa
    {
        private double salario;
        private string cargo;

        public Colaborador(string nome, int idade, double salario, string cargo)
        {
            this.nome = nome;
            this.idade = idade;
            this.salario = salario;
            this.cargo = cargo;

            MensagemPessoa();
            MensagemColaborador();
        }

        public double Salario { get => salario; set => salario = value; }
        public string Cargo { get => cargo; set => cargo = value; }

        protected void MensagemColaborador()
        {
            Console.WriteLine("Salario: " + salario);
            Console.WriteLine("Cargo: " + cargo);
        }

    }
}
