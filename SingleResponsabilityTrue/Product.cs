namespace SingleResponsabilityTrue
{
    public class Product
    {
        public string Name { get; set; }
        public int ProductCode { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product(string name, int productCode, double price, int quantity)
        {
            Name = name;
            ProductCode = productCode;
            Price = price;
            Quantity = quantity;
        }
        
        public override string ToString()
        {
            return $"Наименование: {Name}\n" +
                   $"Код товара: {ProductCode}\n" +
                   $"Цена: ${Price:C}\n" +
                   $"Количество в наличии: {Quantity}\n";
        }
    }
}