using MathLibrary;

Console.WriteLine("== Демонстрация работы MathLibrary.dll ==\n");

double x = 10, y = 4;

Console.WriteLine($"Сложение: {x} + {y} = {Calculator.Add(x, y)}");
Console.WriteLine($"Вычитание: {x} - {y} = {Calculator.Subtract(x, y)}");
Console.WriteLine($"Умножение: {x} * {y} = {Calculator.Multiply(x, y)}");
Console.WriteLine($"Деление: {x} / {y} = {Calculator.Divide(x, y)}");

try
{
    Calculator.Divide(x, 0);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}

Console.WriteLine("\n--- Проверка чисел на простоту ---");

int[] numbersToCheck = { 1, 2, 3, 4, 17, 25, 97 };

foreach (int num in numbersToCheck)
{
    bool isPrime = Calculator.IsPrime(num);
    Console.WriteLine($"Число {num} является простым? -> {isPrime}");
}

Console.WriteLine("\n--- Расширенный функционал ---");

Console.WriteLine($"\nВозведение в степень: {2} ^ {3} = {Calculator.Power(2, 3)}");
Console.WriteLine($"Возведение в степень: {4} ^ {0.5} = {Calculator.Power(4, 0.5)}");

try
{
    Console.WriteLine($"\nФакториал {5} = {Calculator.Factorial(5)}");
    Console.WriteLine($"Факториал {0} = {Calculator.Factorial(0)}");

    Calculator.Factorial(-1);
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Ошибка при вычислении факториала: {ex.Message}");
}

Console.WriteLine("\n--- Решение квадратных уравнений ---");

if (Calculator.SolveQuadratic(1, -5, 6, out double? root1, out double? root2))
{
    Console.WriteLine($"Уравнение x² - 5x + 6 = 0 имеет корни: x1 = {root1}, x2 = {root2}");
}
else
{
    Console.WriteLine("Уравнение не имеет действительных корней");
}
if (Calculator.SolveQuadratic(1, 0, 1, out root1, out root2))
{
    Console.WriteLine($"Уравнение x² + 1 = 0 имеет корни: x1 = {root1}, x2 = {root2}");
}
else
{
    Console.WriteLine("Уравнение x² + 1 = 0 не имеет действительных корней");
}

if (Calculator.SolveQuadratic(1, -4, 4, out root1, out root2))
{
    Console.WriteLine($"Уравнение x² - 4x + 4 = 0 имеет корни: x1 = {root1}, x2 = {root2}");
}

Console.WriteLine("\nНажмите любую клавишу для выхода...");
Console.ReadKey();