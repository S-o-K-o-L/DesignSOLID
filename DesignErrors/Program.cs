using System;
using DesignTrue;

//Создайте программу для учета товаров в магазине электроники с использованием ООП и коллекций.
//Вам нужно создать классы Product, Inventory, а также использовать коллекции для хранения информации о товарах.

//После создания классов и методов, напишите программу для управления инвентарем магазина электроники. Продемонстрируйте,
//как добавлять, удалять, обновлять, искать товары, выводить список товаров,
//а также подсчитывать общее количество и стоимость товаров.

namespace DesignErrors
{
    internal class Program
    {
        public static void Main(string[] args) //Ошибка именования
                                               //Неподвижность
        {
            inv i = new inv();
            int ch;
            do
            {
                dm();
                Console.Write("Выберите действие: ");
                ch = Helper.ReadIntBetweenFromConsole(1, 8, "Введите число в диапазоне от 1 до 8: ");
                switch (ch)
                {
                    case 1:
                        Console.Write("Наименование товара: ");
                        string nm = Console.ReadLine();
                        int prc;
                        bool validInput = false;
                        do
                        {
                            Console.Write("Код товара: ");
                            string input = Console.ReadLine();
                            int.TryParse(input, out prc);
                            if (prc >= -100 && 1234 >= prc) //Жесткость!!!!
                            {
                                validInput = true;
                            }
                            else
                            {
                                Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число или в правильном диапазоне.");
                            }
                        } while (!validInput);

                        double ice;
                        bool validInput1 = false;
                        do
                        {
                            Console.Write("Цена: ");
                            string input = Console.ReadLine();
                            double.TryParse(input, out ice);
                            if (ice >= -100 && 1234 >= ice) //Жесткость!!!!
                            {
                                validInput1 = true;
                            }
                            else
                            {
                                Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число или в правильном диапазоне.");
                            }
                        } while (!validInput1);

                        int ant;
                        bool validInput2 = false;
                        do
                        {
                            Console.Write("Код товара: ");
                            string input = Console.ReadLine();
                            int.TryParse(input, out ant);
                            if (ant >= -100 && 1234 >= ant) //Жесткость!!!!
                            {
                                validInput2 = true;
                            }
                            else
                            {
                                Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число или в правильном диапазоне.");
                            }
                        } while (!validInput2);
                        i.adpr(nm, prc, ice, ant); //Добавление товара
                        break;

                    case 2:
                        int d = Helper.ReadIntFromConsole("Введите код товара для удаления: ");
                        i.remp(d); //Удаление товара
                        break;

                    case 3:
                        int cu = Helper.ReadIntFromConsole("Введите код товара для обновления цены: ");
                        double np = Helper.ReadDoubleFromConsole("Новая цена: ");
                        i.up(cu, np); //Обновление цены товара
                        break;

                    case 4:
                        int ctp = Helper.ReadIntFromConsole("Введите код товара для вывода информации: ");
                        i.ppi(ctp); //Информация о товаре
                        break;

                    case 5:
                        i.palp(); //Список всех товаров
                        break;

                    case 6:
                        Console.WriteLine($"Всего товаров: {i.cpo()}"); //Количество товаров
                        break;

                    case 7:
                        Console.WriteLine($"Общая стоимость товаров: {i.ctv()}"); //Стоимость товаров
                        break;

                    case 8:
                        Console.WriteLine("Выход.");
                        break;

                    default:
                        Console.WriteLine("Неверный выбор. Пожалуйста, выберите корректную опцию.");
                        break;
                }
            } while (ch != 8);
        }

        public static void dm()
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