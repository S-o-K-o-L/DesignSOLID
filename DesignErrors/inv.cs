using System;
using System.Collections.Generic;
using DesignTrue;

namespace DesignErrors
{
    public class inv
    {
        List<rp> pr;

        public inv()
        {
            pr = new List<rp>();
        }

        public void adpr(string name, int productCode, double price, int quantity)
        {
            pr.Add(new rp(name, productCode, price, quantity));
        }

        public void remp(int productCode)
        {
            pr.RemoveAll(p => p.rpc == productCode);
        }

        public void up(int productCode, double newPrice)
        {
            var pri = pr.Find(p => p.rpc == productCode);
            if (pri != null)
            {
                pri.ice = newPrice;
            }
        }

        public void ppi(int productCode)
        {
            var pRp = pr.Find(p => p.rpc == productCode);
            if (pRp != null)
            {
                Console.WriteLine($"Наименование: {pRp.nm}"); //DRY нарушение повторяемость
                Console.WriteLine($"Код товара: {pRp.rpc}");
                Console.WriteLine($"Цена: ${pRp.ice}");
                Console.WriteLine($"Количество в наличии: {pRp.ant}");
            }
            else
            {
                Console.WriteLine("Товар не найден.");
            }
        }

        public void palp()
        {
            foreach (var p in pr)
            {
                Console.WriteLine($"Наименование: {p.nm}"); //DRY нарушение повторяемость
                Console.WriteLine($"Код товара: {p.rpc}");
                Console.WriteLine($"Цена: ${p.ice:C}");
                Console.WriteLine($"Количество в наличии: {p.ant}");
                Console.WriteLine();
            }
        }

        public int cpo()
        {
            return pr.Count;
        }

        public double ctv()
        {
            double tv = 0;
            foreach (var pr in pr)
            {
                tv += pr.ice * pr.ant;
            }
            return tv;
        }
    }
}