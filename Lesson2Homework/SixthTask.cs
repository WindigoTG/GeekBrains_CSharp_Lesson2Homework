using System;

//Олесов Максим

/*6. * Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000.
Хорошим называется число, которое делится на сумму своих цифр.
Реализовать подсчет времени выполнения программы, используя структуру DateTime.*/

namespace Lesson2Homework
{
    class SixthTask
    {
        public static void Run()
        {
            View view = new View();
            view.Print("Зачада 6. Подсчет количества \"хороших\" чисел в диапазоне от 1 до 1 000 000 000\nЭто займет некоторое время. Вы готовы?\nНажмите любую клавишу чтобы начать");
            Console.ReadKey();
            int goodNums = 0;
            int numSum = 0;
            DateTime startTime = DateTime.Now;
            view.Print("\nПоехали!\n\nСильно думаю... \nПожалуйста, подождите");
            for (int i = 1; i <= 1000000000; i++)
            {
                switch (i)
                {
                    case 10000000:
                    case 100000000:
                    case 200000000:
                    case 300000000:
                    case 400000000:
                    case 500000000:
                    case 600000000:
                    case 700000000:
                    case 800000000:
                    case 900000000:
                        {
                            double time = (DateTime.Now - startTime).TotalSeconds;
                            view.Print($"\nЯ не завис, я еще думаю.\nПрошло {time} секунд. Только что прошли число {i}. Наберитесь терпения, осталось \"недолго\"");
                            break;
                        }
                    default:
                        break;
                }
                NumSum(i, ref numSum);
                if (i % numSum == 0)
                    goodNums++;
                numSum = 0;
            }
            double endTime = (DateTime.Now - startTime).TotalSeconds;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            view.Print("\nЯ закончил... Сейчас взорвусь...\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            view.Print($"\nОбщее количество \"хороших\" чисел: {goodNums}\nНа всё про всё ушло {endTime} секунд");
            Console.ResetColor();
            view.Pause();
        }

        private static void NumSum(int num, ref int numSum)
        {
            if (num > 0)
            {
                numSum += num % 10;
                NumSum(num / 10, ref numSum);
            }
        }
    }
}
