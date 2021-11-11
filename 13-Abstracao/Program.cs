using System;

namespace _13_Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            var pf = new PessoaFisica();
            pf.TaxaEmprestimo(1000);

            var pj = new PessoaJuridica();
            pj.TaxaEmprestimo(1000);
        }
    }
}
