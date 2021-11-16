using System;

namespace _11_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Imposto l = new Lider();
            Imposto e = new Estag();
            Imposto t = new TechLead();

            l.ImpostoSobreSalario(6800);
            l.ImpostoSobreAuxilioInternet(200);
            Console.WriteLine("--------------");

            e.ImpostoSobreSalario(4800);
            e.ImpostoSobreAuxilioInternet(100);
            Console.WriteLine("--------------");

            t.ImpostoSobreSalario(8700);
            t.ImpostoSobreAuxilioInternet(200);
            Console.WriteLine("--------------");
        }
    }
}
