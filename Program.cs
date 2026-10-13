using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program78
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите количество штрафных баллов водителя: ");
            if (int.TryParse(Console.ReadLine(), out int points) && points >= 0)
            {
                string result = points <= 5 ? "Предупреждение"
                            : points <= 10 ? "Временное ограничение"
                            : "Лишение прав";
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Введите неотрицательное целое число.");
            }
        }
    }
}