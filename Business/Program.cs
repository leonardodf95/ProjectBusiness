using System;
using System.Globalization;
using Business.Entities.Enums;
using Business.Entities;
using System.Collections.Generic;


namespace Business
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client Data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (dd/MM/yyyy): " );
            DateTime bday = DateTime.Parse(Console.ReadLine());
            Client client = new Client(name, email, bday);
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Order order = new Order(DateTime.Now, status, client);
            Console.Write("How Many Items to this order: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter #" + i + " item data:");
                Console.Write("Product Name: ");
                string productname = Console.ReadLine();
                Console.Write("Product Price: ");
                double productprice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Product product = new Product(productname, productprice);

                Console.Write("Quantity: ");
                int qnt = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(qnt, productprice, product);

                order.AddItem(orderItem);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Order Summary:" );
            Console.WriteLine(order);

        }
    }
}
