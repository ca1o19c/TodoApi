using System;

namespace _11_Polimorfismo
{
    class TechLead : Imposto
    {
        public override void ImpostoSobreSalario(double salario)
        {
            Console.WriteLine("Desconto para Tech Lead do salário R$ " + (salario * 0.20));
        }
    }
}
