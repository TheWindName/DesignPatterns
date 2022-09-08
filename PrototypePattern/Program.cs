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
        shapeRegistry.addShape("CopyBasicRectangle", copyBasicRectangle);

        Rectangle? rectangleCopyToShow = (Rectangle)shapeRegistry.getById("CopyBasicRectangle");

        rectangleCopyToShow.modifyCoordinate(23, 41);

        if (rectangleCopyToShow != null)
            Console.WriteLine($"Coordinate X ---> {rectangleCopyToShow.getCoordinateX()} \nCoordinate Y ---> {rectangleCopyToShow.getCoordinateY()}");
        else
            Console.WriteLine($"There isn't coordinates in the shape because we dind't find anything.");

        Rectangle? rectangleToShow = (Rectangle)shapeRegistry.getById("BasicRectangle");

        if (rectangleToShow != null)
            Console.WriteLine($"Coordinate X ---> {rectangleToShow.getCoordinateX()} \nCoordinate Y ---> {rectangleToShow.getCoordinateY()}");
        else
            Console.WriteLine($"There isn't coordinates in the shape because we dind't find anything.");
    }
}