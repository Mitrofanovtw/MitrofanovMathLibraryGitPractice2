using System;
using System.Linq;

namespace MathLibrary
{
    /// <summary>
    /// Реализация математического калькулятора.
    /// </summary>
    public class Calculator : ICalculator
    {
        private const double Pi = Math.PI;
        private const double CelsiusToFahrenheitRatio = 9.0 / 5.0;
        private const double FahrenheitOffset = 32.0;

        public double Add(double a, double b) => a + b;

        public double Subtract(double a, double b) => a - b;

        public double Multiply(double a, double b) => a * b;

        public double Divide(double dividend, double divisor)
        {
            if (divisor == 0)
                throw new DivideByZeroException("Деление на ноль недопустимо.");
            return dividend / divisor;
        }

        public bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number <= 3) return true;
            if (number % 2 == 0 || number % 3 == 0) return false;
            for (int i = 5; i * i <= number; i += 6)
                if (number % i == 0 || number % (i + 2) == 0) return false;
            return true;
        }

        public double Power(double @base, double exponent)
        {
            if (@base == 0 && exponent < 0)
                throw new ArgumentException("Нулевое основание с отрицательной степенью не определено.");
            return Math.Pow(@base, exponent);
        }

        public int Factorial(int n)
        {
            if (n < 0)
                throw new ArgumentException("Факториал не определён для отрицательных чисел.");
            return n <= 1 ? 1 : Enumerable.Range(2, n - 1).Aggregate(1, (acc, i) => acc * i);
        }

        public QuadraticResult SolveQuadratic(double a, double b, double c)
        {
            if (a == 0)
            {
                if (b == 0) return new QuadraticResult(null, null, false);
                return new QuadraticResult(-c / b, null, true);
            }

            double discriminant = b * b - 4 * a * c;
            if (discriminant < 0) return new QuadraticResult(null, null, false);
            if (discriminant == 0) return new QuadraticResult(-b / (2 * a), null, true);

            double sqrt = Math.Sqrt(discriminant);
            return new QuadraticResult(
                (-b + sqrt) / (2 * a),
                (-b - sqrt) / (2 * a),
                true);
        }

        public double CircleArea(double radius)
        {
            if (radius < 0)
                throw new ArgumentException("Радиус не может быть отрицательным.");
            return Pi * radius * radius;
        }

        public double CelsiusToFahrenheit(double celsius)
            => celsius * CelsiusToFahrenheitRatio + FahrenheitOffset;
    }
}