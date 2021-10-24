using System;

namespace TypesConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt = 100;
            float myFloat = 25.5f;

            // real = inteiro;
            // inteiro = (int) real;

            // String valorReal = real.ToString();
            
            myInt = Convert.ToInt32(myFloat);
            
            Console.WriteLine(myInt);
        }
    }
}