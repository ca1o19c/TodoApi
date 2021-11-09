using System;

namespace _01_Conceitos
{
    class Pessoa
    {
        // Atributos
        public string nome;
        public int idade;

        // Metódos
        public void mensagem()
        {
            Console.WriteLine(this.nome);
            Console.WriteLine(this.idade);
        }
    }
}
