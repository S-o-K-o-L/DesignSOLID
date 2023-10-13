using System;

//Создайте программу для учета товаров в магазине электроники с использованием ООП и коллекций.
//Вам нужно создать классы Product, Inventory, а также использовать коллекции для хранения информации о товарах.

//После создания классов и методов, напишите программу для управления инвентарем магазина электроники. Продемонстрируйте,
//как добавлять, удалять, обновлять, искать товары, выводить список товаров,
//а также подсчитывать общее количество и стоимость товаров.

namespace DesignTrue
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            int choice;
            do
            {
                DisplayMenu();
                Console.Write("Выберите действие: ");
                choice = Helper.ReadIntBetweenFromConsole(1, 8, "Введите число в диапазоне от 1 до 8: ");
                switch (choice)
                {
                    case 1:
                        Console.Write("Наименование товара: ");
                        string name = Console.ReadLine();
                        int productCode = Helper.ReadIntFromConsole("Код товара: "); //Не жесткий
                        double price = Helper.ReadDoubleFromConsole("Цена: ");
                        int quantity = Helper.ReadIntFromConsole("Количество: ");
                        inventory.AddProduct(name, productCode, price, quantity);
                        break;

                    case 2:
                        int code = Helper.ReadIntFromConsole("Введите код товара для удаления: ");
                        inventory.RemoveProduct(code);
                        break;

                    case 3:
                        int codeToUpdate = Helper.ReadIntFromConsole("Введите код товара для обновления цены: ");
                        double newPrice = Helper.ReadDoubleFromConsole("Новая цена: ");
                        inventory.UpdatePrice(codeToUpdate, newPrice);
                        break;

                    case 4:
                        int codeToPrint = Helper.ReadIntFromConsole("Введите код товара для вывода информации: ");
                        inventory.PrintProductInfo(codeToPrint);
                        break;

                    case 5:
                        inventory.PrintAllProducts();
                        break;

                    case 6:
                        Console.WriteLine($"Всего товаров: {inventory.CountProducts()}");
                        break;

                    case 7:
                        Console.WriteLine($"Общая стоимость товаров: {inventory.CalculateTotalValue()}");
                        break;

                    case 8:
                        Console.WriteLine("Выход.");
                        break;

                    default:
                        Console.WriteLine("Неверный выбор. Пожалуйста, выберите корректную опцию.");
                        break;
                }
            } while (choice != 8);
        }

        public static void DisplayMenu()
        {
            Console.WriteLine("1. Добавить товар");
            Console.WriteLine("2. Удалить товар");
            Console.WriteLine("3. Обновить цену товара");
            Console.WriteLine("4. Вывести информацию о товаре");
            Console.WriteLine("5. Вывести список всех товаров");
            Console.WriteLine("6. Подсчитать количество товаров");
            Console.WriteLine("7. Подсчитать общую стоимость товаров");
            Console.WriteLine("8. Выход");
        }
    }
}