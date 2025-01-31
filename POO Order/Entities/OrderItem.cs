using System.Reflection;

namespace Course.Entities
{
    class OrdemItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrdemItem()
        {
        }

        public OrdemItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            return "Product Name: " + Product.Name + ", Quantity: " + Price.ToString("F2") + ", Total: " + SubTotal().ToString("F2");
        }
    }
}
