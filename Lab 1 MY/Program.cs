using Microsoft.Win32;
using System;
using static System.Net.Mime.MediaTypeNames;

namespace Lab_1_MY
{
    internal class Program
    {
        private static void DoMath()
        {
            double x, y, z;

            do // Показывает начало блока который будет выполнять цикл
            {
                Console.WriteLine("Введіть значення x (введіть число <0>  для виходу): ");
                x = double.Parse(Console.ReadLine()); //Console.ReadLine - функция для ввода данных. Convert.ToInt32 - мы конвертируем написанный текст пользователем из string в int.

                if (x == 0)
                {
                    Console.WriteLine("Завершення роботи");
                    Console.Clear();
                    break; // Выход из цикла
                }

                Console.WriteLine("Введіть значення y: ");
                y = double.Parse(Console.ReadLine());
                Console.WriteLine("Введіть значення z: ");
                z = double.Parse(Console.ReadLine());

                double part_1 = (x + Math.Pow(z, 2)) + (y / 4);
                Console.WriteLine("Part_1 = " + part_1);

                double part_2 = z * (y - 2) + (1 / (Math.Pow(z, 2) + 4));
                Console.WriteLine("Part_2 = " + part_2);

                double part_3 = part_1 / part_2;
                Console.WriteLine("Alfa  = " + part_3);

                // Определение диапазона для x
                string rangeX;
                if (x < -10)
                    rangeX = "менше за -10";
                else if (x < -1)
                    rangeX = "менше -1";
                else if (x > 10)
                    rangeX = "більзе за 10";
                else if (x > 1)
                    rangeX = "більше за 1";
                else
                    rangeX = "між -1 і 1 включно";

                // Определение диапазона для результата вычислений
                string rangeResult = (part_3 < 0) ? "негативне" : "позитивне"; // Использывается пернальный оператор

                Console.WriteLine($"Значення x знаходится в діапазоні: {rangeX}"); // Когда строка начинается с символа $, то можно вставлять значения переменных внутрь строки, заключая их в фигурные скобки {}.


                Console.WriteLine($"Результат розрахувань является {rangeResult}");

            } while (x != 0); // Повторяет цикл пока значение не будет равнятся чилу 0
        }

        static Random random = new Random();
        private static void PlayCasino()
        {
            int balance = 100;
            while (true) { 
                int choice = 0;
                Console.Clear();
                Console.WriteLine($"Your balance = {balance}$\n1. Play coinflip (10$ bet/20$ win)\n2. Play guess number(10$ bet/100$ win)\n3. To Exit");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        if (!UserHaveGotBalance(balance))
                            EndGame();
                        balance += CoinFlip();
                        break;
                    case 2:
                        if (!UserHaveGotBalance(balance))
                            EndGame();
                        balance += GuessNumber();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                }
            }
        }

        private static int CoinFlip()
        {
            int choice = 812;
            int flipResult = random.Next(1, 3);
            Console.Clear();
            Console.WriteLine("1. To heads\n2. To tails");
            choice = int.Parse(Console.ReadLine());
            if (choice == flipResult)
            {
                Console.WriteLine("You are right!");
                Console.ReadLine();
                Console.Clear();
                return 10;
            }
            Console.WriteLine("You are wrong(");
            Console.ReadLine();
            Console.Clear();
            return -10;
        }

        private static int GuessNumber()
        {
            int randomNumber = random.Next(1, 10);
            Console.Clear();
            Console.WriteLine("Guess number between 1 to 10:");
            int userAnswer = int.Parse(Console.ReadLine());
            if(randomNumber == userAnswer)
            {
                Console.WriteLine("Wow you are right! You won 100$");
                Console.ReadLine();
                Console.Clear();
                return 100;
            }
            Console.WriteLine($"You are wrong( Random number: {randomNumber}");
            Console.ReadLine();
            Console.Clear();
            return -10;
        }

        private static bool UserHaveGotBalance(int balance) 
        {
            return balance >= 10;
        }

        private static void EndGame()
        {
            Console.Clear();
            Console.WriteLine("You lost all your money! Hahaha");
            Console.ReadLine();
            Environment.Exit(0);
        }

        static void Main()
        {
            while (true) 
            { 
                int choice = 0;
                Console.WriteLine("1. For math\n2. For play casino\n3. For exit");
                choice = int.Parse(Console.ReadLine());
                switch (choice) 
                {
                    case 1: 
                        DoMath();
                        break;
                    case 2:
                        PlayCasino();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
