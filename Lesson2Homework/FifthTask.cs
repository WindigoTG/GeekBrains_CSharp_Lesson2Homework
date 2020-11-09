using System;

//Олесов Максим

//5.а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
//б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.

namespace Lesson2Homework
{
    class FifthTask
    {
        public static void Run()
        {
            View view = new View();
            view.Print("Зачада 5. Определения индекса массы тела");
            double height = view.GetDoublePos("Введите ваш рост в см");
            double weight = view.GetDoublePos("Введите ваш вес в кг");
            double bmi = weight / Math.Pow(height / 100, 2);

            if (bmi < 18.5)
            {
                double tgtWeight = Math.Pow(height / 100, 2) * 18.5;
                view.Print(tgtWeight);
                Console.ForegroundColor = ConsoleColor.Cyan;
                view.Print($"\nВаш ИМТ равен {bmi:0.00}\nУ вас наблюдается дефицит массы тела\nВам следует набрать как минимум {(tgtWeight - weight):0.0} кг");
                Console.ResetColor();
            }
            else if (bmi >= 18.5 && bmi < 25)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                view.Print($"\nВаш ИМТ равен {bmi:0.00}\nМасса вашего тела в норме");
                Console.ResetColor();
            }
            else if (bmi >= 25)
            {
                double tgtWeight = Math.Pow(height / 100, 2) * 25;
                Console.ForegroundColor = ConsoleColor.Magenta;
                view.Print($"\nВаш ИМТ равен {bmi:0.00}\nУ вас наблюдается избыточная масса тела\nВам следует сбросить как минимум {(weight - tgtWeight):0.0} кг");
                Console.ResetColor();
            }
            view.Pause();
        }
    }
}
