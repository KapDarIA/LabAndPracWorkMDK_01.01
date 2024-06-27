namespace Task5
{
    internal abstract class FigureSquare
    {
        public abstract double GetSquare();

        public double GetCircleSquare(double R) => R * R * Math.PI;
    }
}
