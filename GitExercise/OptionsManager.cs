using System;

namespace GitExercise
{
    public static class OptionsManager
    {
        public static string[] OptionsList = {
            "a - Add",
            "s - Subtract",
            "m - Multiply",
<<<<<<< HEAD
            "dr - Drive Remainder",
            "ex - Exit"
=======
            "d - Divide",
            "sabs - Substract Abs",
>>>>>>> Dev-A
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

<<<<<<< HEAD
        public static void DivideRemainder(double a, double b)
        {
            Console.WriteLine($"{a}%{b}={a%b}");
=======
        public static void Divide(double a, double b)
        {
            Console.WriteLine($"{a} : {b} = {a / b}");
        }

        public static void SubtractAbs(double a, double b)
        {
            Console.WriteLine($"|{a} - {b}| = {Math.Abs(a - b)}");
>>>>>>> Dev-A
        }
    }
}
