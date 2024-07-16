using System;

namespace Lab_1_MY
{
    internal class Program
    {
        static void Main()
        {
            double x, y, z;

            do // Показывает начало блока который будет выполнять цикл
            {
                Console.WriteLine("Введіть значення x (введіть число <0>  для виходу): ");
                x = double.Parse(Console.ReadLine()); //Console.ReadLine - функция для ввода данных. Convert.ToInt32 - мы конвертируем написанный текст пользователем из string в int.

                if (x == 0)
                {
                    Console.WriteLine("Завершення роботи: ");
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
    }
}
