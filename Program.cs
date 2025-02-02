// Written by Kapil
// Feb 1 2025

namespace HomeWork1
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Homework1 class
            HomeWork1 homework = new HomeWork1();

            Console.WriteLine("Choose a program to run:");
            Console.WriteLine("1. The Triangle Farmer");
            Console.WriteLine("2. The Four Sisters and the Duckbear");
            Console.WriteLine("3. The Dominion of Kings");
            Console.WriteLine("4. The Defense of Consolas");
            Console.WriteLine("5. Repairing the Clocktower");
            Console.Write("Enter your choice (1-5): ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    // Triangle Farmer
                    Console.Write("Enter the base of the triangle: ");
                    double baseLength = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the height of the triangle: ");
                    double height = Convert.ToDouble(Console.ReadLine());

                    homework.BaseLength = baseLength;
                    homework.Height = height;
                    Console.WriteLine($"The area of the triangle is: {homework.GetTriangleArea()}");
                    break;

                case 2:
                    // Four Sisters and the Duckbear
                    Console.Write("Enter the number of chocolate eggs: ");
                    int eggs = Convert.ToInt32(Console.ReadLine());

                    homework.ChocolateEggs = eggs;
                    Console.WriteLine($"Each sister gets {homework.GetSistersEggs()} chocolate eggs.");
                    Console.WriteLine($"The duckbear gets {homework.GetDuckbearEggs()} chocolate eggs.");
                    break;

                case 3:
                    // Dominion of Kings
                    Console.Write("Enter the number of provinces: ");
                    int provinces = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the number of duchies: ");
                    int duchies = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the number of estates: ");
                    int estates = Convert.ToInt32(Console.ReadLine());

                    homework.Provinces = provinces;
                    homework.Duchies = duchies;
                    homework.Estates = estates;
                    Console.WriteLine($"Your total score is: {homework.GetTotalScore()}");
                    break;

                case 4:
                    // Defense of Consolas
                    Console.Title = "Defense of Consolas";
                    Console.Write("Target Row? ");
                    int targetRow = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Target Column? ");
                    int targetColumn = Convert.ToInt32(Console.ReadLine());

                    // For background 
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Red;
                    
                    homework.TargetRow = targetRow;
                    homework.TargetColumn = targetColumn;
                    Console.WriteLine(homework.GetDeploymentLocations());

                    // Play a sound
                    Console.Beep();
                    break;

                case 5:
                    // Repairing the Clocktower
                    Console.Write("Enter a number: ");
                    int number = Convert.ToInt32(Console.ReadLine());

                    homework.Number = number;
                    Console.WriteLine(homework.GetTickOrTock());
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please select a number between 1 and 5.");
                    break;
            }

        }
    }
}
