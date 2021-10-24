using System;

namespace Enumerators
{
    class Program
    {
        static void Main(string[] args)
        {
            var mouse = new Product(1, "Mouse", 190.80, EProductType.Product);

            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.Name);
            Console.WriteLine(mouse.Price);
            Console.WriteLine(mouse.Type);

            var priceInDollarProduct = mouse.PriceInDollar(5.65);
            Console.WriteLine(priceInDollarProduct);

            var laptopMaintenance = new Product(2, "Laptop maintenance", 600.20, EProductType.Service);
            
            Console.WriteLine(laptopMaintenance.Id);
            Console.WriteLine(laptopMaintenance.Name);
            Console.WriteLine(laptopMaintenance.Price);
            Console.WriteLine(laptopMaintenance.Type);

            var priceInDollarService = laptopMaintenance.PriceInDollar(5.65);
            Console.WriteLine(priceInDollarService);
                
        }
    }

    struct Product
    {
        public int Id;
        public string Name;
        public double Price;
        public EProductType Type;

        public Product(int id, string name, double price, EProductType type)
        {
            Id = id;
            Name = name;
            Price = price;
            Type = type;
        }

        public double PriceInDollar(double dollar)
        {
            return Price * dollar;
        }
    }

    enum EProductType
    {
        Product = 1,
        Service = 2
    }
}