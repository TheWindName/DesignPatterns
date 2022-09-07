using BuilderPattern;

internal class Program
{
    private static void Main(string[] args)
    {
        PizzaBuilder builderNormalPizza = new PizzaBuilder();

        Director director = new Director();

        director.makePizzaNormal(builderNormalPizza);

    }
}