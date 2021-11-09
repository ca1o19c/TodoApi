using System;

namespace _11_Polimorfismo
{
    class Lider : Imposto
    {
        public override void ImpostoSobreSalario(double salario)
        {
            Console.WriteLine("Desconto para Líder do salário R$ " + (salario * 0.14));
        }
    }
}
