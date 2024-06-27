namespace Task2
{
    internal class ShapeFactory
    {
        public IShape GetShape(string shapeType)
        {
            if (shapeType == null)
            {
                return null;
            }
            if (shapeType.Equals("CIRCLE", StringComparison.InvariantCultureIgnoreCase))
            {
                return new Circle();
            }
            else if (shapeType.Equals("RECTANGLE", StringComparison.InvariantCultureIgnoreCase))
            {
                return new Rectangle();
            }
            else if (shapeType.Equals("SQUARE", StringComparison.InvariantCultureIgnoreCase))
            {
                return new Square();
            }
            else if (shapeType.Equals("TRIANGLE", StringComparison.InvariantCultureIgnoreCase))
            {
                return new Triangle();
            }

            return null;
        }

        public IShape GetRegister(string shapeType)
        {
            if (shapeType == null) 
            {
                return null;
            }
            else if (shapeType == shapeType.ToUpper())
            {
                return new Circle();
            }

            return null;
        }
    }
}
