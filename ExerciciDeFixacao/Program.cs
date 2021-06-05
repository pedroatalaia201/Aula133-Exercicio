using System;
using System.Globalization;
using System.Collections.Generic;
using ExerciciDeFixacao.Entities;

namespace ExerciciDeFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercício de Fixação;

            List<Product> products = new List<Product>();

            Console.Write("Ener the number of products: ");
            int num = int.Parse(Console.ReadLine());

            for(int i = 1; i <= num; i++)
            {
                Console.WriteLine($"Product #{i} data");
                Console.Write("Common, used or imported (c/u/i)? ");
                char op = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: $ ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (op == 'c')
                {
                    products.Add(new Product(name, price));
                }

                else if(op == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());

                    products.Add(new UsedProduct(name, price, date));
                }

                if (op == 'i')
                {
                    Console.Write("Customs fee: $ ");
                    double fee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    products.Add(new ImportedProduct(name, price, fee));
                }               
            }

            Console.WriteLine("PRICE TAGS:\n");

            foreach (Product item in products)
            {
                Console.WriteLine(item.PriceTag());
            }
        }
    }
}
