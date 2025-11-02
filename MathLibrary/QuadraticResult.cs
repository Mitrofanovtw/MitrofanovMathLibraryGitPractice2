namespace MathLibrary
{
    /// <summary>
    /// Результат решения квадратного уравнения.
    /// </summary>
    public sealed record QuadraticResult
    {
        public double? X1 { get; init; }
        public double? X2 { get; init; }
        public bool HasRealRoots { get; init; }

        public QuadraticResult(double? x1, double? x2, bool hasRealRoots)
        {
            X1 = x1;
            X2 = x2;
            HasRealRoots = hasRealRoots;
        }
    }
}