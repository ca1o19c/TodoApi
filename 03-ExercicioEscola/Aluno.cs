using System;

namespace _03_ExercicioEscola
{
    class Aluno
    {
        // Atributos
        public string nome;
        public double nota1, nota2;

        // Métodos

        // Média
        public double Media()
        {
            return (nota1 + nota2) / 2;
        }

        // Situação
        public string Situacao(double media)
        {
            return (media > 7) ? "Aprovado" : "reprovado";
        }

        // Mensagem
        public void Mensagem()
        {
            double obterMedia = Media();

            string obterSituacao = Situacao(obterMedia);

            Console.WriteLine(nome + " sua situação é " + obterSituacao + " com média " + obterMedia);
        }
    }
}
