using MathLibrary;

Console.WriteLine("== Демонстрация работы MathLibrary.dll ==\n");

double x = 10, y = 4;

Console.WriteLine($"Add(5, 3) = {Calculator.Add(5, 3)}");
Console.WriteLine($"Subtract(5, 3) = {Calculator.Subtract(5, 3)}");
Console.WriteLine($"Multiply(5, 3) = {Calculator.Multiply(5, 3)}");

try
{
    Console.WriteLine($"Divide(5, 0) = {Calculator.Divide(5, 0)}");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}

Console.WriteLine($"IsPrime(7) = {Calculator.IsPrime(7)}");
Console.WriteLine($"IsPrime(8) = {Calculator.IsPrime(8)}");

Console.WriteLine($"Power(2, 3) = {Calculator.Power(2, 3)}");
try
{
    Calculator.Power(0, -1);
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Ошибка в Power: {ex.Message}");
}

Console.WriteLine($"Factorial(5) = {Calculator.Factorial(5)}");
try
{
    Calculator.Factorial(-1);
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Ошибка в Factorial: {ex.Message}");
}

Console.WriteLine("\n--- Решение квадратных уравнений ---");

double? x1, x2;
if (Calculator.SolveQuadratic(1, -3, 2, out x1, out x2))
{
    Console.WriteLine($"Корни: x1 = {x1}, x2 = {x2}");
}
else
{
    Console.WriteLine("Нет действительных корней.");
}

Console.WriteLine("\nНажмите любую клавишу для выхода...");
Console.ReadKey();