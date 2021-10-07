using System;

namespace OOP_Elective_1
{
    public class Fibonacci
    {
        public double Fib(Func<double, double> func, double a, double b, int n)
        {
            // Генерация первых (n + 1) чисел Фибоначчи
            int[] Fb = new int[n + 1];
            Fb[0] = 1;
            Fb[1] = 1;
            for (int i = 2; i < n + 1; i++)
                Fb[i] = Fb[i - 1] + Fb[i - 2];

            // Вычисление начальных точек деления x1, x2
            double x1 = a + (b - a) * (Fb[n - 2]) / (Fb[n]);
            double x2 = a + (b - a) * (Fb[n - 1]) / (Fb[n]);
            
            // Вычисление значения функции в точках x1, x2
            double y1 = func(x1);
            double y2 = func(x2);

            while (n != 2)
            {
                n--;
                if (y1 > y2)
                {
                    a = x1;
                    x1 = x2;
                    x2 = b - (x1 - a);
                    y1 = y2;
                    y2 = func(x2);
                }
                else
                {
                    b = x2;
                    x2 = x1;
                    x1 = a + (b - x2);
                    y2 = y1;
                    y1 = func(x1);
                }
            }
            // Возврат точки экстремума
            return (a + b) / 2;
        }
    }
}
