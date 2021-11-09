using System;

namespace _06_Encapsulamento
{
    class Aluno
    {
        private double nota1, nota2;

        private double Media()
        {
            return (nota1 + nota2) / 2;
        }

        public void Mensagem()
        {
            Console.Write("Entre com a primeira nota: ");
            nota1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Entre com a segunda nota: ");
            nota2 = Convert.ToInt32(Console.ReadLine());

            double value = Media();
            Console.WriteLine("Você está com a média " + value);
        }
    }
}
