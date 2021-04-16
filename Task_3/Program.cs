using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Программа подсчета нечетных положительных чисел");
            Console.WriteLine("Вводите числа по одному, для завершения введите 0: ");

            while (true)
                if (!int.TryParse(Console.ReadLine(), out int x)) 
                { 
                    Console.WriteLine("Введите именно число");
                }
                else 
                {
                    do
                    {
                        if (x > 0 && x % 2 != 0); 
                        sum = sum + x;
                        Console.WriteLine($"Конец. Сумма нечетных положительных чисел равна: {sum}");
                        Console.ReadKey();
                    }
                    while (x != 0);
                 
                }
            //Console.WriteLine($"Конец. Сумма нечетных положительных чисел равна: {sum}");
            //Console.ReadKey();
        }
    }
}
