using System;
using System.Globalization;
using Sexto.Entities;
using Sexto.Entities.Enums;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string ClientName = Console.ReadLine();
            Console.Write("Email: ");
            string ClientEmail = Console.ReadLine();
            Console.Write("Birth Date (DD/MM/YYYY: ");
            DateTime BirthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter order data: ");
            Console.Write("Status (Pending_Payment, Processing, Shipped, Delivered): ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            client _client = new client(ClientName, ClientEmail, BirthDate);
            Order order = new Order(DateTime.Now, status, _client);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i< n; i++)
            {
                Console.WriteLine("Enter #" + i + " item data:");
                Console.Write("Product Name: ");
                string productName = Console.ReadLine();
                Console.Write("Product Price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int productQuantity = int.Parse(Console.ReadLine());

                Request request = new Request(productName, productQuantity, productPrice);

                request.AddRequest(request);
            }
            
        }
    }
}

/*            Comment C1 = new Comment("Have a nice trip!");
            Comment C2 = new Comment("Wow that's awesome!");
            Post p1 = new Post(DateTime.Parse("07/04/2022 19:20:04"),
                "Traveling to New Zealand",
                "I'm going to visit this wonderful country!", 12);
            p1.AddComment(C1);
            p1.AddComment(C2);


            Comment C3 = new Comment("Good night!");
            Comment C4 = new Comment("May the Force be with you");
            Post p2 = new Post(DateTime.Parse("27/03/2022 14:50:44"),
                "Good night guys",
                "See you tomorrow", 5);
            p2.AddComment(C3);
            p2.AddComment(C4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);*/