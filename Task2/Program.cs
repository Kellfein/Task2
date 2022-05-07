using System;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        { // Задание 1
            Console.WriteLine(" Введите целое число");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Число чётное");
            }
            else
            {
                Console.WriteLine("Число нечётное");
            }
            Console.ReadKey();

            // Задание 2
            Console.WriteLine("Приветствую! Сколько карт у вас на руках?");
            int amount = 0;
            int iteration = 0;
            int i = int.Parse(Console.ReadLine());
            string cardValue;
            for (int j = 1; j <= i; j++)
            {
                iteration++;
                Console.WriteLine($"Введите значение {iteration}-й карты ");
                cardValue = Console.ReadLine();
                switch (cardValue)
                {
                    case "J":
                    case "Q":
                    case "K":
                    case "T":
                        amount += 10;
                        break;
                    default:
                        amount += int.Parse(cardValue);
                        break;
                }
            }
            Console.WriteLine($"Сумма очков ваших карт = {amount}");
            Console.ReadKey();

            // Задание 3

            Console.WriteLine(" Введите целое число ");
            int n = int.Parse(Console.ReadLine());
            int x = 1;
            bool chek = false;
            while (x < n - 1)
            {
                x++;
                if (n % x == 0)
                {
                    chek = true;
                }
            }
            if (chek == true)
            {
                Console.WriteLine("Введёное число не является простым");
            }
            else
            {
                Console.WriteLine("Введено простое число");
            }

            Console.ReadKey();
        }
    }
}
