using System;

namespace MathLibrary
{

    public class Calculator
    {
        /// <summary>
        /// Плюс.
        /// </summary>
        public static double Add(double a, double b)
        {
            return a + b;
        }

        /// <summary>
        /// Минус.
        /// </summary>
        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        /// <summary>
        /// Умножение.
        /// </summary>
        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        /// <summary>
        /// Деление.
        /// </summary>
        public static double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Делитель не может быть равен нулю.");
            }
            return a / b;
        }

        /// <summary>
        /// Проверяет, является ли число простым (оптимизировано).
        /// </summary>
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number <= 3) return true;
            if (number % 2 == 0 || number % 3 == 0) return false;
            for (int i = 5; i * i <= number; i += 6)
            {
                if (number % i == 0 || number % (i + 2) == 0) return false;
            }
            return true;
        }

        /// <summary>
        /// Определяет факториал чисел.
        /// </summary>
        public static int Factorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Факториал не определен для отрицательных чисел.");
            }
            if (n == 0 || n == 1) return 1;
            int result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        /// <summary>
        /// Возводит число в степень.
        /// </summary>
        public static double Power(double number, double power)
        {
            if (number == 0 && power < 0)
            {
                throw new ArgumentException("Нулевое основание с отрицательной степенью не определено.");
            }
            return Math.Pow(number, power);
        }

        /// <summary>
        /// Вычисляет квадратное уравнение.
        /// </summary>
        public static bool SolveQuadratic(double a, double b, double c, out double? x1, out double? x2)
        {
            x1 = null;
            x2 = null;

            if (a == 0)
            {
                if (b != 0)
                {
                    x1 = -c / b;
                    return true;
                }
                return false;
            }

            double discriminant = b * b - 4 * a * c;

            if (discriminant < 0)
            {
                return false;
            }
            else if (discriminant == 0)
            {
                x1 = -b / (2 * a);
                x2 = x1;
                return true;
            }
            else
            {
                x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                return true;
            }
        }
    }
}