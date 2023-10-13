using Projeto_Aula_132.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Projeto_Aula_132.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        private double total = 0;

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void addItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void removeItem(OrderItem item)
        {
            Items.Remove(item);
        }


        public override string ToString()
        {
            StringBuilder SB = new StringBuilder();
            SB.AppendLine("Order Summary");
            SB.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            SB.Append("Order Status: ");
            SB.AppendLine(Status.ToString());
            SB.Append("Client: ");
            SB.Append(Client.PersonName);
            SB.Append(" (");
            SB.Append(Client.DateBirth.ToString());
            SB.Append(") ");
            SB.Append(" - ");
            SB.AppendLine(Client.Email);
            SB.AppendLine("Order items: ");

            foreach (OrderItem item in Items)
            {
                SB.Append(item.Product.ProductName);
                SB.Append(", ");
                SB.Append("$");
                SB.Append(item.Price.ToString("F2", CultureInfo.InvariantCulture));
                SB.Append(", ");
                SB.Append("Quantity: ");
                SB.Append(item.Quandtity);
                SB.Append(", Subtotal: $");
                double SubTotal = item.subTotal();
                SB.AppendLine(SubTotal.ToString("F2", CultureInfo.InvariantCulture));
                total += SubTotal;
            }
            SB.Append("Total price:");
            SB.Append(total.ToString("F2", CultureInfo.InvariantCulture));

            return SB.ToString();


        }
    }
}
