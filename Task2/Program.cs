using System;


namespace Task2
{
    internal class Program
    {
        private static uint _n;

        static void Main(string[] args)
        {
            Console.WriteLine("Введите N : ");
            if (uint.TryParse(Console.ReadLine(), out _n))
            {
                for (uint step = 1; step <= _n; step++)
                {
                    for (uint outputStars = 0; outputStars < step; outputStars++)
                        Console.Write('*');

                    Console.WriteLine();
                }
                return;
            }
            Console.WriteLine("Не верный ввод данных.");
        }
    }
}
