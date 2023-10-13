namespace Projeto_Aula_132.Entities
{
    internal class OrderItem
    {
        public int Quandtity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int quandtity, double price, Product product)
        {
            Quandtity = quandtity;
            Price = price;
            Product = product;
        }

        public double subTotal()
        {
            return Quandtity * Price;
        }
    }
}
