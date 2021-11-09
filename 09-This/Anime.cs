using System;

namespace _09_This
{
    class Anime
    {
        private string nome = "Dragon Ball";

        public Anime(string nome)
        {
            Console.WriteLine(nome);
            Console.WriteLine(this.nome);
        }
    }
}
