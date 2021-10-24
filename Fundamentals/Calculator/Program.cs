using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Write("Primeiro valor: ");
            float value1 = float.Parse(Console.ReadLine());

            Console.Write("Segundo valor: ");
            float value2 = float.Parse(Console.ReadLine());

            Console.Write("Operação (Sum, Subtract, Multiplication, Divide): ");
            string operation = Console.ReadLine();

            CalculatorAction(value1, value2, operation);
        }

        static void CalculatorAction(float v1, float v2, string o)
        {
            string aux = o.ToUpper();

            switch (aux)
            {
                case "SUM":
                    Console.WriteLine($"{v1} + {v2} = {Sum(v1, v2)}");
                    break;
                case "SUBTRACT":
                    Console.WriteLine($"{v1} - {v2} = {Subtract(v1, v2)}");
                    break;
                case "MULTIPLICATION":
                    Console.WriteLine($"{v1} * {v2} = {Multiplication(v1, v2)}");
                    break;
                case "DIVIDE":
                    Console.WriteLine($"{v1} / {v2} = {Divide(v1, v2)}");
                    break;
                default:
                    Console.WriteLine("Operation not found!");
                    break;
            }
        }

        static float Sum(float v1, float v2)
        {
            return v1 + v2;
        }

        static float Subtract(float v1, float v2)
        {
            return v1 - v2;
        }

        static float Multiplication(float v1, float v2)
        {
            return v1 * v2;
        }

        static float Divide(float v1, float v2)
        {
            if (v2 != 0)
            {
                return v1 / v2;
            }

            return 0;
        }
    }
}