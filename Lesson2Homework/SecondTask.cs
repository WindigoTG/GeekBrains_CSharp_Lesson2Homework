//Олесов Максим

//2. Написать метод подсчета количества цифр числа.

namespace Lesson2Homework
{
    class SecondTask
    {
        public static void Run()
        {
            View view = new View();
            view.Print("Зачада 2. Подсчет количества цифр числа");
            int number = view.GetInt("Введите целое число");
            int total = 0;
            NumCount(number, ref total);
            view.Print($"\nВы ввели число {number}\nКоличетво цифр во введённом числе: {total}");
            view.Pause();
        }
        private static void NumCount(int num, ref int total)
        {
            if (num > 0)
            {
                NumCount(num / 10, ref total);
                total++;
            }
        }
    }
}
