using System;

namespace _11_Polimorfismo
{
    class Imposto
    {
        public virtual void ImpostoSobreSalario(double salario)
        {
            Console.WriteLine("Desconto padrão do salário R$ " + (salario * 0.1));
        }

        public void ImpostoSobreAuxilioInternet(double salario)
        {
            Console.WriteLine("Desconto padrão do auxilio internet R$ " + (salario * 0.1));
        }
    }
}
