using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Превожу напряжение и сопротивление к типу double, вывожу силу тока и мощность с форматом 2 знака после запятой
            double voltage;
            double resistance;
            
            Console.WriteLine("Введите значение напряжения: ");
            double.TryParse(Console.ReadLine(), out voltage);
            
            Console.WriteLine("Введите значение cопротивления: ");
            double.TryParse(Console.ReadLine(), out resistance);

            Console.WriteLine($"Сила тока = {(voltage / resistance).ToString("F")}");
            Console.WriteLine($"Мощность = {(voltage * voltage / resistance).ToString("F")}");

        }
    }
}
