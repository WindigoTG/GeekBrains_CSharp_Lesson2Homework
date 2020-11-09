//Олесов Максим

//3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.

namespace Lesson2Homework
{
    class ThirdTask
    {
        public static void Run()
        {
            View view = new View();
            view.Print("Зачада 3. Подсчет суммы нечетных положительных чисел среди введённых");
            int sum = 0;
            int inputResult;

            do
            {
                inputResult = view.GetInt("Введите целое число. Введите 0 чтобы закончить ввод");
                if (inputResult % 2 != 0 && inputResult > 0)
                    sum += inputResult;
            } while (inputResult != 0);

            view.Print($"\nСумма нечетных положительных чисел равна {sum}");
            view.Pause();
        }
    }
}
