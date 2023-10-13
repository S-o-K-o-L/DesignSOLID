using System;
using System.Collections.Generic;

namespace SingleResponsabilityError
{
    public class Inventory //Причина для изменения - управление инвентарем (добавить новыый метод),
                           //изменить способ вывода информации
    {
        List<Product> products;

        public Inventory()
        {
            products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void RemoveProduct(int productCode)
        {
            products.RemoveAll(p => p.ProductCode == productCode);
        }

        public void UpdatePrice(int productCode, double newPrice)
        {
            var product = products.Find(p => p.ProductCode == productCode);
            if (product != null)
            {
                product.Price = newPrice;
            }
        }

        public void PrintProductInfo(int productCode) //SRP нарушение
        {
            var product = products.Find(p => p.ProductCode == productCode);
            if (product != null)
            {
                Console.WriteLine(product.ToString());
            }
            else
            {
                Console.WriteLine("Товар не найден.");
            }
        }

        public void PrintAllProducts() //SRP нарушение
        {
            foreach (var product in products)
            {
                Console.WriteLine(product.ToString());
                Console.WriteLine();
            }
        }

        public int CountProducts()
        {
            return products.Count;
        }

        public double CalculateTotalValue()
        {
            double totalValue = 0;
            foreach (var product in products)
            {
                totalValue += product.Price * product.Quantity;
            }
            return totalValue;
        }
    }
}