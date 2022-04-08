using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace Sexto.Entities
{
    class Request
    {
        public string Product { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public Request()
        {
        }

        public Request(string product, int quantity, double price)
        {
            Product = product;
            Quantity = quantity;
            Price = price;
        }

        public void AddRequest(Request request)
        {
            Requests.Add(request);
        }

        public void RemoveRequest(Request request)
        {
            Requests.Remove(request);
        }

        public double SubTotal()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            return Product + ", $" + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity: " + Quantity + "Subtotal: $" + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
