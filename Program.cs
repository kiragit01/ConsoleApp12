using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Составьте таблицу значений функции y = -5x² + 2x +1 на отрезке [-5; 5] с шагом h = 2.

            for (int x = -5; x <= 5; x += 2)
                Console.WriteLine($"x = {x} \t y = {-5 * Math.Pow(x, 2) + 2 * x + 1}");
            Console.WriteLine();

            //Вариант 12
            Console.WriteLine("f(x) = (x - 3)^2 / 2 + 2\n");
            for (double x = -2; x <= 7; x += 0.1)
                Console.WriteLine($"f({x:f1}) = {Math.Pow(x - 3, 2) / 2 + 2:f2}");

            Console.ReadKey();
        }
    }
}
