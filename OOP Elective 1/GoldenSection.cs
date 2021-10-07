using System;

namespace OOP_Elective_1
{
    public class GoldenSection
    {
        // Число Фи
        private double PHI = 1.6180339887498949;

        // Поиск точки максимума
        public double GetMax(Func<double, double> func, double a, double b, double eps)
        {
            // Точки деления x1 и x2
            double x1 = b - (b - a) / PHI;
            double x2 = a + (b - a) / PHI;

            while (true)
            {
                x1 = b - (b - a) / PHI;
                x2 = a + (b - a) / PHI;

                if (func(x1) <= func(x2))
                    a = x1;
                else
                    b = x1;

                if (Math.Abs(b - a) < eps)
                    break;
            }
            // Возврат точки максимума
            return (a + b) / 2;
        }

        public double GetMin(Func<double, double> func, double a, double b, double eps)
        {
            // Точки деления
            double x1;
            double x2;

            while (true)
            {
                x1 = b - (b - a) / PHI;
                x2 = a + (b - a) / PHI;

                if (func(x1) >= func(x2))
                    a = x1;
                else
                    b = x1;

                if (Math.Abs(b - a) < eps)
                    break;
            }
            // Возврат точки минимума
            return (a + b) / 2;
        }
    }
}
