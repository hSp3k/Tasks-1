using System;


namespace Task7
{
    internal class Program
    {
        private static byte _theFirstNumber, _theSecondNumber;

        static void Main(string[] args)
        {
            Console.WriteLine("Введите два числа : ");
            if (byte.TryParse(Console.ReadLine(), out _theFirstNumber) &&
                byte.TryParse(Console.ReadLine(), out _theSecondNumber))
            {
                Console.WriteLine($"Побитовое 'И' : {_theFirstNumber & _theSecondNumber}\n" +
                                  $"Побитовое 'ИЛИ' : {_theFirstNumber | _theSecondNumber}\n" +
                                  $"Побитовое 'исключающее ИЛИ' : {_theFirstNumber ^ _theSecondNumber}");
                return;
            }
            Console.WriteLine("Не верный ввод данных.");
        }
    }
}
