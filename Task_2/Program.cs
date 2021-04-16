using System;

namespace Task_2
{
    class Program
    {
        static int rightNum()
        {
			while (true)
				if (!int.TryParse(Console.ReadLine(), out int x))
					Console.WriteLine("Неверно");
				else Console.WriteLine("Верно" + x);
		}

    static void Main(string[] args)
        {
	
			int a;
			int sum = 0;

			do
				{
					Console.Write("Введите число: ");
					a = int.Parse(Console.ReadLine());

					if (a > 0 && a % 2 != 0) sum = sum + a;
				}
				while (a != 0);
				Console.WriteLine($"Конец. Сумма нечетных положительных чисел равна: {sum}");

			Console.ReadKey();
		}
    }
}
