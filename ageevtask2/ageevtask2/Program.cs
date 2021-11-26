using System;

namespace ageevtask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус окружности : ");
            double r = double.Parse(Console.ReadLine());
            double l = Math.Round((2 * Math.PI * r), 3);
            double S = Math.Round((Math.PI * Math.Pow(r, 2)), 3);
            Console.WriteLine($"Длина окружности равна {l}, площадь равна {S}");
        }
    }
}
