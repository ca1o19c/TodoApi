using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Conceitos
{
    class Pessoa
    {
        // Atributos
        public string nome;
        public int idade;

        // Metódos
        public void Mensagem()
        {
            Console.WriteLine(this.nome + " tem " + this.idade + " anos");
        }
    }
}
