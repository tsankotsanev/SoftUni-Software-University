namespace _05.Restaurant

{
    public class Product 
    {
        protected Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
        public string Name { get; set; }

        public decimal Price { get; set; }

       
    }
}
