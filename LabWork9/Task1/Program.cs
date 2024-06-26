namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AirFlight printer = new AirFlight();
            printer.Print();

            Console.WriteLine();

            EquilateralTrianglecs figure = new EquilateralTrianglecs(10);
            figure.PrintInformation();

        }
    }
}
