using MathLibrary;

Console.WriteLine("=== MathLibrary после рефакторинга ===\n");

var calc = new Calculator();

Console.WriteLine($"Add(5, 3) = {calc.Add(5, 3)}");
Console.WriteLine($"IsPrime(17) = {calc.IsPrime(17)}");
Console.WriteLine($"Factorial(5) = {calc.Factorial(5)}");
Console.WriteLine($"CircleArea(5) = {calc.CircleArea(5):F2}");
Console.WriteLine($"0°C → {calc.CelsiusToFahrenheit(0)}°F");

var result = calc.SolveQuadratic(1, -3, 2);
if (result.HasRealRoots)
{
    Console.WriteLine($"Корни: x1 = {result.X1}, x2 = {result.X2}");
}
else
{
    Console.WriteLine("Нет действительных корней.");
}

Console.WriteLine("\nНажмите любую клавишу...");
Console.ReadKey();