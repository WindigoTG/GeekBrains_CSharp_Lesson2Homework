using System;

//Олесов Максим

//7. a) Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b);
//б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.

namespace Lesson2Homework
{
    class SeventhTask
    {
        public static void Run()
        {
            View view = new View();
            view.Print("Зачада 7. Вывод на экран чисел от a до b и подсчет их суммы");
            int a, b;
            int sum = 0;
            do
            {
                view.Print("\nВведите два целых числа. Числа не должны быть равны друг другу");
                a = view.GetInt("Введите первое число");
                b = view.GetInt("Введите второе число");
            } while (a == b);

            if (b < a)
            {
                a = a + b;
                b = a - b;
                a = a - b;
            }
            Console.WriteLine();
            PrintNumbers(a, b, ref sum);
            view.Print($"\n\nСумма чисел равна {sum}");
            view.Pause();
        }

        private static void PrintNumbers(int a, int b, ref int sum)
        {
            View view = new View();
            if (a <= b)
            {
                view.Print($"{a}  ", false);
                PrintNumbers(a + 1, b, ref sum);
                sum += a;
            }
        }
    }
}
