//Олесов Максим

namespace Lesson2Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstTask.Run();
            SecondTask.Run();
            ThirdTask.Run();
            if (FourthTask.Run())
            {
                FifthTask.Run();
                SixthTask.Run();
                SeventhTask.Run();
            }
        }
    }
}
