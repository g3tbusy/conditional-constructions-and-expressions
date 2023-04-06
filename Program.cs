using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace условные_конструкции_и_выражения
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  на 3
            Console.Write("Введите число A: ");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число B: ");
            double b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число C: ");
            double c = Convert.ToInt32(Console.ReadLine());
            double d = b * b - 4 * a * c;
            double d2 = Math.Sqrt(d);
            double x1, x2;

            Console.WriteLine($"Дискриминант = {d}");

            if (d < 0)
                Console.WriteLine("Корней нет.");

            else if (d == 0)
            {
                x1 = b / -1 / (2 * a);
                Console.WriteLine($"Ответ: x = {x1}");
            }

            else if (d > 0)
            {
                x1 = (-b + d2) / (2 * a);
                x2 = (-b - d2) / (2 * a);
                Console.WriteLine($"Ответ: x1 = {x1}, x2 = {x2}");
            }
            // на 4
            double x, y;
            int start, end;

            Console.Write("Введите начальное значение X: ");
            start = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите конечное значение X: ");
            end = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("x\t|y");

            for (int i = start; i <= end; i++)
            {
                x = i;
                y = a * x * x + b * x + c;
                Console.WriteLine("{0}\t|{1}", x, y);
            }
            Console.ReadKey();
        }
    }
}
