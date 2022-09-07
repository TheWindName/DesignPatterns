using FactoryMethod;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("We create a ZOO");

        Cage birdCage = new BirdCage();

        Console.WriteLine("We can insert birds in the cage");

        birdCage.insertAnimal();

        birdCage.feed("grass");

        Console.WriteLine("Also, We can insert tigers in another cage");

        Cage tigerCage = new TigerCage();

        tigerCage.insertAnimal();

        tigerCage.feed("Zebre");
    }
}