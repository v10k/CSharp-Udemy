using System;
using System.Globalization;
using course_2.Entities;
using course_2.Entities.Enums;

namespace course_2 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter client data:");
            
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, date);

            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++) {
                Console.WriteLine($"Enter #{i} item data:");
                
                Console.Write("Product name: ");
                string pName = Console.ReadLine();

                Console.Write("Product price: ");
                double pPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Quantity: ");
                int pQuantity = int.Parse(Console.ReadLine());

                Product p = new Product(pName, pPrice);

                OrderItem item = new OrderItem(pQuantity, pPrice, p);

                order.AddItem(item);
            }

            Console.WriteLine("\n" + order);


        }
    }
}