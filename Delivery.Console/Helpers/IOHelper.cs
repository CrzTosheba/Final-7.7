using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Helpers
{
    internal static class IOHelper
    {
        internal static int AskNumber(int min = 0, int max = int.MaxValue) // метода для запросов числовых значений, если не число, то выдаем ошибку
        {
            while (true)
            {
                var response = Console.ReadLine();
                if (int.TryParse(response, out var number) && number > min && number < max) // парсим то что ввели и проверяемс
                {
                    return number;
                }
                Console.WriteLine("Введено не корректное значение");
                Console.WriteLine($"Нужно ввести целое число в интервале ({min};{max})");

            }
        }
    }
}
