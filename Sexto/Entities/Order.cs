using System;
using System.Globalization;
using System.Collections.Generic;
using Sexto.Entities;
using Sexto.Entities.Enums;
using System.Text;


namespace Sexto.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public client Client { get; set; }
        public List<Request> Requests { get; set; } = new List<Request>();

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus Status, client client)
        {
            Moment = moment;
            Status = Status;
            Client = client;
        }


        public double total()
        {
            double sum = 0.0;
            foreach(Request request in Requests)
            {
                sum += request.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY");
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items:");
            foreach (Request request in Requests)
            {
                sb.AppendLine(request.ToString());
            }
            sb.AppendLine("Total price: $" + total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
