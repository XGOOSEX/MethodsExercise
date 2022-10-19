using System.Security.Cryptography.X509Certificates;

namespace MethodsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What is your Name?");
            //var name = Console.ReadLine();

            //Console.WriteLine("What is your favorite color?");
            //var favoriteColor = Console.ReadLine();

            //Console.WriteLine("What is your favorite animal?");
            //var favoriteAnimal = Console.ReadLine();

            //Console.WriteLine("What is your favorite Band?");
            //var favoriteBand = Console.ReadLine();
            //Console.WriteLine($"Your name is {name}. Your favorite color is {favoriteColor}. Your favorite animal is a {favoriteAnimal}. Your favorite band is {favoriteBand}.");

            Console.WriteLine(Sum(10, 2));
            Console.WriteLine(Multiply(100, 5));
            Console.WriteLine(ParamsAdd(2, 4));
            Console.WriteLine(ParamsAdd(2, 4, 6));
            Console.WriteLine(ParamsAdd(1, 1, 1, 1, 1)); 

        }
        public static int Sum(int num1, int num2)
        { 
            int sum = num1 + num2; 
            
            return sum;
        }

        public static int Multiply(int num1, int num2)
        {
            int product = num1 * num2;

            return product; 
        }
        public static int ParamsAdd(params int[] ListNumbers)
        {
            int total = 0;

            foreach (int i in ListNumbers)
            {
                total = total + i; 
            }
            return total; 
        }
    }
}