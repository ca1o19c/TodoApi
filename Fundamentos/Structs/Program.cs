using System;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = new Product(1, "Mouse", 190.80);
            
            Console.WriteLine(product.Id);
            Console.WriteLine(product.Name);
            Console.WriteLine(product.Price);

            var priceInDolar = product.PriceInDolar(5.65);
            Console.WriteLine(priceInDolar);
        }
    }

    struct Product
    {
        public int Id;
        public string Name;
        public double Price;

        public Product(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public double PriceInDolar(double dolar)
        {
            return Price * dolar;
        }
    }
}
