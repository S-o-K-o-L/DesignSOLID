namespace OpenClosedTrue
{
    public class DiscountedProduct : Product
    {
        public double Discount { get; set; }

        public DiscountedProduct(string name, int productCode, double price, int quantity, double discount)
            : base(name, productCode, price, quantity)
        {
            Discount = discount;
        }

        public double GetDiscountedPrice()
        {
            // Вычисляем цену с учетом скидки
            return Price * (1 - Discount);
        }

        public override string ToString()
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