using PrototypePattern;

internal class Program
{
    private static void Main(string[] args)
    {
        ShapeRegistry shapeRegistry = new ShapeRegistry();

        IShape basicRectangle = new Rectangle(2, 2);

        IShape bigRectangle = new Rectangle(50, 60);

        IShape copyBasicRectangle = basicRectangle.clone();

        shapeRegistry.addShape("BasicRectangle", basicRectangle);
        shapeRegistry.addShape("BigRectangle", bigRectangle);
        shapeRegistry.addShape("BasicRectangle", basicRectangle);
    }
}