namespace Task5
{
    internal class Square : FigureSquare
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public override double GetSquare()
        {
            Console.Write("Введите высоту:");
            Width = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите ширину:");
            Height = Convert.ToDouble(Console.ReadLine());

            return Width * Height;
        }
    }
}
