using Decorator_Pattern.Component;
using Decorator_Pattern.ConcreteComponent;
using Decorator_Pattern.ConcreteDecorator;
using Decorator_Pattern.Decorator.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    public class Client
    {
        public void run()
        {
            IProduct product;
            int option,optionProduct;

            while (true)
            {
                Console.WriteLine("Please enter product's option:\n1.Watch\n2.Book\n3.Break\n");

                if (!int.TryParse(Console.ReadLine(), out optionProduct))
                {
                    Console.WriteLine("Please provide valid input");
                    continue;
                }

                if (optionProduct == 3) break;

                product = getBaseProduct(optionProduct);
                if (product == null)
                {
                    Console.WriteLine("Please enter valid option");
                    continue;
                }

                while (true)
                {
                    Console.WriteLine("Current Price of " +  product.getName() + " is : " + product.getPrice());
                    Console.WriteLine("Please Enter your option:\n1. Vat.\n2. Shipping.\n3. Discount\n4. Free\n5. Break");
                   
                    if (!int.TryParse(Console.ReadLine(), out option))
                    {
                        Console.WriteLine("Please provide valid input");
                        continue;
                    }

                    if (option == 5) break;

                    product = getProduct(product, option);
                }

                Console.WriteLine("Final Price of " + product.getName() + " is : " + product.getPrice());
            }
        }

        IProduct getBaseProduct(int option)
        {
            if (option == 1) return new Watch();
            else if (option == 2) return new Book();
            else return null;
        }

        IProduct getProduct(IProduct product, int option)
        {
            if (option == 1)
            {
                Console.WriteLine("Please set the amount(in percentages): ");
                double amount = double.Parse(Console.ReadLine());

                product = new Vat(product, amount);
            }

            else if (option == 2)
            {
                Console.WriteLine("Please set the Shipping Charge(per Weight) :  ");
                int amount = int.Parse(Console.ReadLine());

                product = new Shipping(product, amount);
            }
            else if (option == 3)
            {
                Console.WriteLine("Please set the Discount Rate(in percentages): ");
                int amount = int.Parse(Console.ReadLine());

                product = new Discount(product, amount);
            }

            else if (option == 4)
            {
                product = new FreeOffer(product);
            }

            else
            {
                Console.WriteLine("Please enter valid option");
            }

            return product;
        }

    }
}
