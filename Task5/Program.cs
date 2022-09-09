using System;


namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint Sum = 0;
            for (uint Number = 1; Number < 1000; Number++)
            {
                if (Number % 3 == 0 || Number % 5 == 0)
                    Sum += Number;
            }
            Console.WriteLine($"Сумма : {Sum}");
        }
    }
}
