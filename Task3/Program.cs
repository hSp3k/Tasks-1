using System;


namespace Task3
{
    internal class Program
    {
        private static uint _n;

        static void Main(string[] args)
        {
            Console.WriteLine("Введите N : ");
            if (uint.TryParse(Console.ReadLine(), out _n))
            {
                for (uint countStars = 1, step = 1; step <= _n; step++, countStars += 2)
                {
                    for (uint outputSpace = 0; outputSpace < _n - step; outputSpace++)
                        Console.Write(' ');

                    for (uint outputStars = 0; outputStars < countStars; outputStars++)
                        Console.Write('*');

                    Console.WriteLine();
                }
                return;
            }
            Console.WriteLine("Не верный ввод данных.");
        }
    }
}
