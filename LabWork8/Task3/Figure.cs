namespace Task3
{
    abstract class Figure
    {
        public abstract void GetArea();

        public abstract void GetPerimeter();

        public abstract void GetInfo();

        public abstract string GetName { get; set; }
        //сигнатуры не понравились :(
    }
}
