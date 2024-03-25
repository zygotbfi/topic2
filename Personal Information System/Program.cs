using System;

class Program
{
    static void Main(string[] args)
    {
        // Variable Initialization
        string name = "";
        int age = 0;
        double height = 0.0;

        // User Input
        while (true)
        {
            try
            {
                Console.WriteLine("Welcome to Your Personal Information System!");
                Console.WriteLine();
                Console.Write("Enter your name: ");
                name = Console.ReadLine();

                Console.Write("Enter your age: ");
                age = int.Parse(Console.ReadLine());
                if (age <= 0)
                    throw new ArgumentException("Age must be a positive integer.");

                Console.Write("Enter your height in meters: ");
                height = double.Parse(Console.ReadLine());
                if (height <= 0)
                    throw new ArgumentException("Height must be a positive number.");

                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Invalid input:", ex.Message);
            }
        }

        // Type Conversion
        double doubleAge = (double)age;

        // Conditional Statements
        if (doubleAge >= 18)
        {
            Console.WriteLine("Welcome to the adult section.");
        }
        else
        {
            Console.WriteLine("You are still a minor.");
        }

        // Constant Declaration
        const int LEGAL_DRINKING_AGE = 21;

        if (doubleAge >= LEGAL_DRINKING_AGE)
        {
            Console.WriteLine("You are legally allowed to drink.");
        }
        else
        {
            Console.WriteLine("Sorry, you are underage for drinking.");
        }

        // String Manipulation
        string personalInfo = $"{name}, {age}, {height} meters.";
        Console.WriteLine("Personal Information: " + personalInfo);
        Console.WriteLine("Thank you for using Your Personal Information System!");
    }
}
