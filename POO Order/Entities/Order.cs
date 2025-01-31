using System.Diagnostics.CodeAnalysis;
using System.Text;
using Course.Entities.Enums;

namespace Course.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public Client Client { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrdemItem> Items { get; set; } = new List<OrdemItem>();

        public Order() 
        { 
        }

        public Order(DateTime moment, Client client, OrderStatus status)
        {
            Moment = moment;
            Client = client;
            Status = status;
        }

        public void AddItem(OrdemItem item) 
        {
            Items.Add(item);
        }

         public void RemoveItem(OrdemItem item) 
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0;
            foreach (OrdemItem item in Items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order Moment: " + Moment.ToString("dd/MM/yyyy HH/mm/ss"));
            sb.AppendLine("Order Status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order Item: ");
            foreach (OrdemItem item in Items) { 
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total : $" + Total());
            return sb.ToString();   
        }
    }
}
