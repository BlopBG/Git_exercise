using System;

namespace GitExercise
{
    public static class OptionsManager
    {
        public static string[] OptionsList = {
            "a - Add",
            "s - Subtract",
            "m - Multiply",
            "dr - Divide Remainder",
            "ex - Exit",
            "d - Devide",
            "sabs - Subtract Abs",
            "pow - Power", 
            "log - Logarithm",
            "fact - Sum of 2 factorials"
        };

        public static void Add(double a, double b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }

        public static void Multiply(double a, double b)
        {
            Console.WriteLine($"{a} x {b} = {a * b}");
        }

        public static void Subtract(double a, double b)
        {
            Console.WriteLine($"{a} - {b} = {a - b}");
        }

        public static void DivideRemainder(double a, double b)
        {
            Console.WriteLine($"{a} % {b} = {a % b}");
        }
        public static void Divide(double a, double b) 
        {
            Console.WriteLine($"{a} : {b} = {a / b}");
        }

        public static void SubtractAbs(double a, double b)
        {
            Console.WriteLine($"|{a} - {b}| = {Math.Abs(a - b)}");
        }
        public static void Pow(double a, double b)
        {
            Console.WriteLine($"{a} ^ {b} = {Math.Pow(a,b)}");
        }
        public static void Log(double a, double b)
        {
            Console.WriteLine($"Log of {a} with base {b} = {Math.Log(a, b)}");
        }

        public static void Factorial(double a, double b)
        {
            long factA = CalculateFact((int)a);
            long factB = CalculateFact((int)a);
            Console.WriteLine($"{a}! + {b}! = {factA+factB}");

        }

        private static long CalculateFact(int a)
        {
            long ans = 1;
            for (int i = 1; i <= a; i++) 
                ans *= i;
            return ans;
        }
    }
}
