using System;

namespace TiposNulos
{
    class Program
    {
        static void Main(string[] args)
        {
            int? idade = 0;
            Console.WriteLine(idade);

            idade = null;
            Console.WriteLine(idade);

            idade = 25;
            Console.WriteLine(idade);
        }
    }
}
