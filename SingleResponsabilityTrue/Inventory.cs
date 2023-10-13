using System;
using System.Collections.Generic;

namespace SingleResponsabilityTrue
{
    public class Inventory //Причина для изменения - управление инвентарем (добавить новыый метод)
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

        public string GetProductInfo(int productCode)
        {
            var product = products.Find(p => p.ProductCode == productCode);
            if (product != null)
            {
                return product.ToString();
            }
            return "Товар не найден.";
        }

        public List<Product> GetAllProducts()
        {
            return products;
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