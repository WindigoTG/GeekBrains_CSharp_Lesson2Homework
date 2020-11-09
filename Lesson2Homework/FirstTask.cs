//Олесов Максим

//1. Написать метод, возвращающий минимальное из трех чисел.

namespace Lesson2Homework
{
    class FirstTask
    {
        public static void Run()
        {
            View view = new View();
            view.Print("Зачада 1. Определение минимального числа из трёх");
            int first = view.GetInt("Введите первое целое число");
            int second = view.GetInt("Введите второе целое число");
            int third = view.GetInt("Введите третье целое число");
            int min = first;
            min = second < min ? second : min;
            min = third < min ? third : min;
            view.Print($"\nВведённые числа: {first}, {second}, {third}\nМинимальное число: {min}");
            view.Pause();
        }
    }
}
