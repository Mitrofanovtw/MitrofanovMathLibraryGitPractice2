using System;

namespace MathLibrary
{
    /// <summary>
    /// Интерфейс математического калькулятора.
    /// </summary>
    public interface ICalculator
    {
        double Add(double a, double b);
        double Subtract(double a, double b);
        double Multiply(double a, double b);
        double Divide(double dividend, double divisor);
        bool IsPrime(int number);
        double Power(double @base, double exponent);
        int Factorial(int n);
        QuadraticResult SolveQuadratic(double a, double b, double c);
        double CircleArea(double radius);
        double CelsiusToFahrenheit(double celsius);
    }
}