using System;

namespace TypeNullable
{
    class Program
    {
        static void Main(string[] args)
        {
            int? age = 0;
            Console.WriteLine(age);

            age = null;
            Console.WriteLine(age);

            age = 25;
            Console.WriteLine(age);
        }
    }
}
