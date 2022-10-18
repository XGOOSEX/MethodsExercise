namespace MethodsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your Name?");
            var name = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            var favoriteColor = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            var favoriteAnimal = Console.ReadLine();

            Console.WriteLine("What is your favorite Band?");
            var favoriteBand = Console.ReadLine();
            Console.WriteLine($"Your name is {name}. Your favorite color is {favoriteColor}. Your favorite animal is {favoriteAnimal}. Your favorite band is {favoriteBand}.");
            
             

        }
    }
}