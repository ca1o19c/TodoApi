using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowMessage("Olá, mundo!");

            var name = ConcatenateName("Caio", "Antonio");
            Console.WriteLine(name);
        }

        static void ShowMessage(string msg)
        {
            Console.WriteLine(msg);
        }

        static string ConcatenateName(
            string name,
            string lastName,
            int age = 19
        )
        {
            string retorno = name + " " + lastName + " tem " + age;

            return retorno;
        }
    }
}