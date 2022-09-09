using System;


namespace Task1
{
    internal class Program
    {
        private static float _side1, _side2;

        static void Main(string[] args)
        {
            Console.WriteLine("Введите длинны сторон : ");
            if (float.TryParse(Console.ReadLine(), out _side1) && _side1 >= 0 &&
                float.TryParse(Console.ReadLine(), out _side2) && _side2 >= 0)
            {
                Console.WriteLine($"Площадь : {_side1 * _side2}");
                return;
            }
            Console.WriteLine("Не верный ввод данных.");
        }
    }
}
