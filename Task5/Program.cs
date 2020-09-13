using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вводим значение катетов, находим гипотенузу с помощью Math.Sqrt
            double leg1; double leg2;
            Console.WriteLine("Введите значение первого катета: ");
            double.TryParse(Console.ReadLine(), out leg1);
            
            Console.WriteLine("Введите значение второго катета: ");
            double.TryParse(Console.ReadLine(), out leg2);

            Console.WriteLine($"Гипотенуза = {Math.Sqrt(leg1 * leg1 + leg2 * leg2)}"); // Можно через Math.Pow()
            Console.WriteLine("Нажмите Enter, чтобы закрыть.");

        }
    }
}
