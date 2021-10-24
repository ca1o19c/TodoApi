using System;

namespace ConvertendoTipos
{
    class Program
    {
        static void Main(string[] args)
        {
            int inteiro = 100;
            float real = 25.5f;

            // real = inteiro;
            // inteiro = (int) real;

            // String valorReal = real.ToString();
            
            inteiro = Convert.ToInt32(real);
            
            Console.WriteLine(inteiro);
        }
    }
}