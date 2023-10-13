using System;

namespace OpenClosedFalse
{
    public class Helper //Переиспользуемый модуль
    {
        public static int ReadIntBetweenFromConsole(int left = Int32.MinValue, int right = Int32.MaxValue,
            string prompt = "Введите целое число: ")
        {
            int result;
            bool validInput = false;

            do
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                int.TryParse(input, out result);
                if (result >= left && right >= result)
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число или в правильном диапазоне.");
                }
            } while (!validInput);

            return result;
        }
        
        public static int ReadIntFromConsole(string prompt = "Введите целое число: ")
        {
            int result;
            bool validInput = false;

            do
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                
                if (int.TryParse(input, out result))
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
                }
            } while (!validInput);
            
            return result;
        }
        
        public static double ReadDoubleFromConsole(string prompt = "Введите число c плавающей точкой: ")
        {
            double result;
            bool validInput = false;

            do
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                
                if (double.TryParse(input, out result))
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
                }
            } while (!validInput);
            
            return result;
        }
    }
}