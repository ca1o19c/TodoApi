using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new string[2];
            arr[0] = "Item 1";
            arr[1] = "Item 2";

            var arr2 = arr;
            
            Console.WriteLine("arr");
            ShowArray(arr);
            
            Console.WriteLine("arr2");
            ShowArray(arr2);

            arr[0] = "Mudei";
            
            Console.WriteLine("arr");
            ShowArray(arr);
            
            Console.WriteLine("arr2");
            ShowArray(arr2);
        }

        static void ShowArray(String[] array)
        {
            foreach (var a in array)
            {
                Console.WriteLine(a);
            }
            
            Console.WriteLine();
        }
    }
}