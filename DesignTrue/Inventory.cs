using System;
using System.Collections.Generic;

namespace DesignTrue
{
    public class Inventory
    {
        List<Product> products;

        public Inventory()
        {
            products = new List<Product>();
        }

        public void AddProduct(string name, int productCode, double price, int quantity)
        {
            products.Add(new Product(name, productCode, price, quantity));
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

        public void PrintProductInfo(int productCode)
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

        public void PrintAllProducts()
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