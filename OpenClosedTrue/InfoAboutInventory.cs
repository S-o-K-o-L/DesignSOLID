using System;
using System.Collections.Generic;

namespace OpenClosedTrue
{
    public class InfoAboutInventory //Изменить способ вывода или добавить
    {
        public static void PrintToConsoleInfoAboutItemInInventory(string infoAboutItemInInventory)
        {
            Console.WriteLine(infoAboutItemInInventory);
        }
        
        public static void PrintToConsoleInfoAboutAllInventory(List<Product> products)
        {
            products.ForEach(Console.WriteLine);
        }
    }
}