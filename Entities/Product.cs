namespace Projeto_Aula_132.Entities
{
    internal class Product
    {
        public string ProductName { get; set; }
        public double Price { get; set; }

        public Product()
        {
        } 

        public Product(string productName, double price)
        {
            ProductName = productName;
            Price = price;
        }
    }
}
