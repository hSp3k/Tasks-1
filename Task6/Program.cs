using System;


namespace Task6
{
    internal class Program
    {
        private static float _side1, _side2, _side3;

        static void Main(string[] args)
        {
            Console.WriteLine("Введите длины сторон : ");
            if (float.TryParse(Console.ReadLine(), out _side1) && _side1 >= 0 &&
                float.TryParse(Console.ReadLine(), out _side2) && _side2 >= 0 &&
                float.TryParse(Console.ReadLine(), out _side3) && _side3 >= 0 &&
                _side1 <= _side2 + _side3 && _side2 <= _side1 + _side3 && _side3 <= _side1 + _side2) // Проверка на "Существование такого треугольника"
            {
                float Perimeter = (_side1 + _side2 + _side3) / 2;
                Console.WriteLine($"Площадь : {Math.Sqrt(Perimeter * (Perimeter - _side1) * (Perimeter - _side2) * (Perimeter - _side3))}");
                return;
            }
            Console.WriteLine("Не верный ввод данных.");
        }
    }
}
