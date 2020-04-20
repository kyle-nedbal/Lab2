using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            string userWantsToContinue;
            Console.WriteLine("Welcome to Grand Circus Room Detail Generator!");

            do
            {
                Console.WriteLine(" ");

                Console.WriteLine("Enter Length in inches:");
                double lengthInches = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Width in inches:");
                double widthInches = double.Parse(Console.ReadLine());

                double areaInches = (lengthInches * widthInches);
                double perimeterInches = (lengthInches + lengthInches + widthInches + widthInches);

                double areaFeet = Math.Floor(areaInches / 12);
                areaInches -= (areaFeet * 12);

                double perimeterFeet = Math.Floor(perimeterInches / 12);
                perimeterInches -= (perimeterFeet * 12);

                Console.WriteLine("Area: " + areaFeet + " feet " + areaInches + " inches ");
                Console.WriteLine("Perimeter: " + perimeterFeet + " feet " + perimeterInches + " inches ");
              
                Console.WriteLine(" ");

                Console.WriteLine("Continue? (y/n)");
                userWantsToContinue = Console.ReadLine();

            } while (userWantsToContinue.ToUpper() == "Y");

            Console.WriteLine(" ");
            Console.WriteLine("Goodbye!");
        }
    }
}
