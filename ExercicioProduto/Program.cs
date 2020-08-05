
using ExercicioProduto.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            Console.WriteLine("Enter the numbe of products:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Product #{i+1} data:");
                Console.Write("Common, used or imported (c/u/i)?");
                char s = char.Parse(Console.ReadLine());
                Console.Write("Name:");
                string name = Console.ReadLine();
                Console.Write("Price:");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (s == 'i')
                {
                    Console.Write("Customs fee:");
                    double cust = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, cust));

                }
                else if (s == 'u')
                {
                    Console.Write("Manufcture date (DD/MM/YYYY):");
                    DateTime data = DateTime.Parse(Console.ReadLine());

                    list.Add(new UsedProduct(name, price, data));
                }
                else
                {
                    list.Add(new Product(name, price));
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("PRICE TAGS:");

            foreach (Product p in list)
            {
                Console.WriteLine(p.priceTag());
            }
        }
    }
}
