using System;

namespace _13_Abstracao
{
    abstract class Padrao
    {
        // Obrigatório
        public abstract void TaxaEmprestimo(double valor);

        // Opcional
        public void CalculoPoupanca(double valor, double taxa)
        {
            Console.WriteLine("Ganhos obtidos pela poupança R$ " + (valor * taxa));
        }
    }
}
