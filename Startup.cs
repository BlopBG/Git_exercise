using System;
using System.ComponentModel;
using System.Diagnostics.SymbolStore;

namespace GitExercise
{
    public class Startup
    {
        private const string Password = "abcd1234";
        public static void Main()
        {
            while (true)
            {
                bool inAuthorized = CheckCredentials();
                if (inAuthorized)
                {
                    Console.WriteLine("Access denied.");
                    Console.ReadKey(true);
                    return;
                }
                Console.WriteLine("Console Calculator App");
                Console.WriteLine(new string('-', 15));

                Console.Write("a = ");
                double a = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

                Console.Write("b = ");
                double b = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

                Console.WriteLine("Choose one from the listed options:");
                foreach (string option in OptionsManager.OptionsList)
                {
                    Console.WriteLine($"\t{option}");
                }

                Console.Write("Option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "a":
                        OptionsManager.Add(a, b);
                        break;
                    case "s":
                        OptionsManager.Subtract(a, b);
                        break;
                    case "m":
                        OptionsManager.Multiply(a, b);
                        break;
                    case "d":
                        OptionsManager.Divide(a, b);
                        break;
                    case "sabs":
                        OptionsManager.SubtractAbs(a, b);
                        break;
                    case "dr":
                        OptionsManager.DivideRemainder(a, b);
                        break;
                    case "pow":
                        OptionsManager.Pow(a, b);
                        break;
                    case "log":
                        OptionsManager.Log(a, b);
                        break;
                    case "fact":
                        OptionsManager.Factorial(a, b);
                        break;
                    case "ex":
                        Console.Clear();
                        Console.WriteLine("Goodbye");
                        Console.ReadKey(true);
                        return;
                }
            }
        }
        private static bool CheckCredentials()
        {
            Console.Write("Enter password to gain acces: ");
            string password = Console.ReadLine();
            Console.Clear();

            return password == Password;
        }
    }
}
