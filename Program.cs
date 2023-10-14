using System;
using System.ComponentModel;
using System.Data;
using Projeto_Aula_132.Entities;
using Projeto_Aula_132.Entities.Enums;

namespace Projeto_Aula_132
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Class Client
            Console.WriteLine("Enter cliente data:");

            Console.Write("Name: ");
            string PersonName = Console.ReadLine();

            Console.Write("Email: ");
            string Email = Console.ReadLine();

            Console.Write("Birth Date: ");
            DateTime BirthDate = DateTime.Parse(Console.ReadLine());

            Client Cliente = new Client(PersonName, Email, BirthDate);
            Order Order;

            // Class Oder
            Console.WriteLine("Enter Order data:");

            Console.Write("Status: ");
            OrderStatus OS = (OrderStatus)Enum.Parse(typeof(OrderStatus), Console.ReadLine());

            Order = new Order(DateTime.Now, OS, Cliente);

            Console.Write("How many items to this order? ");
            int ItemsQuantity = int.Parse(Console.ReadLine());

            for (int i = 1; i <= ItemsQuantity; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");

                Console.Write("Product name: ");
                string ProductName = Console.ReadLine();

                Console.Write("Product price: ");
                double ProductPrice = double.Parse(Console.ReadLine());                

                Product Product = new Product(ProductName, ProductPrice);

                Console.Write("Quantity: ");
                int ProductQuantity = int.Parse(Console.ReadLine());

                OrderItem OrderItem = new OrderItem(ProductQuantity, ProductPrice, Product);

                Order.addItem(OrderItem);
            }            

            Console.WriteLine(Order);


        }
    }
}
