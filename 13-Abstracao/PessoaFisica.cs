using System;

namespace _13_Abstracao
{
    class PessoaFisica : Padrao
    {
        public override void TaxaEmprestimo(double valor)
        {
            Console.WriteLine("Taxa de empréstimo para Pessoa Física R$ " + (valor * 0.1));
        }
    }
}
