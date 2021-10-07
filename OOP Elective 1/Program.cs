using System;

namespace OOP_Elective_1
{
    internal class Program
    {
        static double Function(double x)
        {
            return Math.Pow(x + 1, 3) + 5 * Math.Pow(x, 2);
        }

        static void Main(string[] args)
        {
            GoldenSection gs = new GoldenSection();

            double a = -2;
            double b = 2;
            double eps = 0.001;

            /* Использование метода золотого сечения */
            double max1 = gs.GetMax(Function, a, b, eps); // Точка МАКСИМУМА 1
            double ymax1 = Function(max1); // Значение функции в точке максимума 1

            double min1 = gs.GetMin(Function, a, b, eps); // Точка МИНИМУМА 1
            double ymin1 = Function(min1); // Значение функции в точке минимума 1

            Console.WriteLine($"Метод золотого сечения:");
            Console.WriteLine($"На отрезке [{a};{b}], точность: {eps}\n\tmax1 = {max1}\n\tymax1 = {ymax1}\n\tmin1 = {min1}\n\tymin1 = {ymin1}");

            // Изменение интервала исследования
            a = -8;
            b = 0;

            double max2 = gs.GetMax(Function, a, b, eps); // Точка МАКСИМУМА 2
            double ymax2 = Function(max2); // Значение функции в точке максимума 2

            double min2 = gs.GetMin(Function, a, b, eps); // Точка МИНИМУМА 2
            double ymin2 = Function(min2); // Значение функции в точке максимума 2

            Console.WriteLine($"На отрезке [{a};{b}], точность: {eps}\n\tmax2 = {max2}\n\tymax2 = {ymax2}\n\tmin2 = {min2}\n\tymin2 = {ymin2}\n");


            Fibonacci fb = new Fibonacci();

            // Изменение интервала исселедования
            a = -2;
            b = 2;
            int n = 10;

            /* Использование метода чисел Фибоначчи */
            double x1 = fb.Fib(Function, a, b, n); // Точка экстемума 1
            double y1 = Function(x1); // Значение функции в точке экстремума 1

            Console.WriteLine($"Метод чисел Фибоначчи:");
            Console.WriteLine($"На отрезке [{a};{b}], число итераций: {n}\n\ty = {y1}\n");

            a = -8;
            b = 0;

            double x2 = fb.Fib(Function, a, b, n); // Точка экстремума 2
            double y2 = Function(x2); // Значение функции в точке экстремума 2

            Console.WriteLine($"На отрезке [{a};{b}], число итераций: {n}\n\ty = {y2}");
        }
    }
}
