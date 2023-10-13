namespace OpenClosedFalse
{
    public class Product
    {
        public string Name { get; set; }
        public int ProductCode { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        
        public double Discount { get; set; }

        public Product(string name, int productCode, double price, int quantity, double discount) //Изменение
        {
            Name = name;
            ProductCode = productCode;
            Price = price;
            Quantity = quantity;
            Discount = discount;
        }
        
        public double GetDiscountedPrice() //Изменение
        {
            return Price * (1 - Discount);
        }

        public override string ToString() //Изменение
        {
            return $"Наименование: {Name}\n" +
                   $"Код товара: {ProductCode}\n" +
                   $"Цена: {Price:C}\n" +
                   $"Количество в наличии: {Quantity}\n" +
                   $"Скидка: {Discount:P}\n" +
                   $"Цена со скидкой: {GetDiscountedPrice():C}";
        }
    }
}