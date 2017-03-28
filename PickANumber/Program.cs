using System;

namespace PickANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberGuessed;
            bool isNumberGuessed = false;
            int theAnswer;
            Random rng = new Random();

            theAnswer = rng.Next(1, 26);

            do
            {
                Console.WriteLine("Enter a number between 1 and 25");
                numberGuessed = int.Parse(Console.ReadLine());

                if (numberGuessed == theAnswer)
                {
                    Console.WriteLine("You got it!");
                    isNumberGuessed = true;
                }
                else
                {
                    Console.WriteLine(numberGuessed > theAnswer ? "Too high! Try again!" : $"Too low! Try again!");
                }
            } while (!isNumberGuessed);
        }
    }
}
