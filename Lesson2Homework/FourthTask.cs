using System;

//Олесов Максим

//4. Реализовать метод проверки логина и пароля. На вход подается логин и пароль.
//На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
//Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
//С помощью цикла do while ограничить ввод пароля тремя попытками.

namespace Lesson2Homework
{
    class FourthTask
    {
        public static bool Run()
        {
            View view = new View();
            string login ="root";
            string password = "GeekBrains";
            view.Print("Зачада 4. Проверка ввода логина и пароля");
            Console.ForegroundColor = ConsoleColor.Yellow;
            view.Print("Для получения доступа к дальнейшим задачам необходимо произвести авторизацию");
            Console.ResetColor();

            int tryCount = 3;
            do
            {
                view.Print($"Количество попыток для входа: {tryCount}");
                string logInput = view.GetString("Введите логин");
                string passInput = view.GetString("Введите логин");
                if (logInput == login && passInput == password)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    view.Print("Вход выполнен. Вам предоставлен доступ к дальнейшим задачам");
                    Console.ResetColor();
                    view.Pause();
                    return true;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                view.Print("Логин и/или пароль не вереню Попробуйте еще раз\n");
                Console.ResetColor();
                tryCount--;
            } while (tryCount > 0);
            Console.ForegroundColor = ConsoleColor.Red;
            view.Print("В доступе к дальнейшим задачам отказано");
            Console.ResetColor();
            view.Pause();
            return false;
        }
    }
}
