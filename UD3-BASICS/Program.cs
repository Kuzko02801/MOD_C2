using System;

namespace UD3_BASICS
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise1();
            Exercise2();
        }

        // Exercise 1.
        public static void Exercise1()
        {
            Console.WriteLine("Exercise 1");
            int a = 10;
            int b = 5;

            Console.WriteLine($"Sum: {a + b}");
            Console.WriteLine($"Difference: {a - b}");
            Console.WriteLine($"Multiplication: {a * b}");
            Console.WriteLine($"Division: {a / b}");
            Console.WriteLine($"Module: {a % b}");

            Console.WriteLine("\n");
        }

        // Exercise 2.
        public static void Exercise2()
        {
            Console.WriteLine("Exercise 2");
            
            int N = 10;
            double A = 5.0;
            char C = 'a';

            Console.WriteLine($"Value of N: {N} Value of A: {A} Value of C: {C}");
            Console.WriteLine($"Sum of N + A: {N + A}");
            Console.WriteLine($"Numeric value of C: {(int) C}");

            Console.WriteLine("\n");
        }

        // Exercise 3.
        public static void Exercise3()
        {
            Console.WriteLine("Exercise 3");

            int X = 10;
            int Y = 5;

            double N = 1.0;
            double M = 0.5;

            Console.WriteLine($"X: {X} Y: {Y} N: {N} M:{M}");
            Console.WriteLine($"Sum of X and Y: {X + Y}");
            Console.WriteLine($"Difference of X minus Y: {X - Y}");
            Console.WriteLine($"Product of X by Y: {X * Y}");
            Console.WriteLine($"Quotient of X by Y: {X / Y}");
            Console.WriteLine($"Reminder of X by Y: {X % Y}");
            Console.WriteLine($"Sum of N and M: {N + M}");
            Console.WriteLine($"Difference of N minus M: {N - M}");
            Console.WriteLine($"Product of N by M: {N * M}");
            Console.WriteLine($"Quotient of N by M: {N / M}");
            Console.WriteLine($"Reminder of N by M: {N % M}");
            Console.WriteLine($"Sum of X and N: {X + N}");
            Console.WriteLine($"Quotient of Y by M: {Y / M}");
            Console.WriteLine($"Reminder of Y by M: {Y % M}");
            Console.WriteLine($"Double of each variable => 2X = {2 * X} 2Y = {2 * Y} 2N = {2 * N} 2M = {2 * M}");
            Console.WriteLine($"Sum of all variables: {X + Y + M + N}");
            Console.WriteLine($"Product of all variables: {X * Y * M * N}");

            Console.WriteLine("\n");
        }

        // Exercise 4.
        public static void Exercise4()
        {
            int N = 15;
            Console.WriteLine($"Increment N in 77 {N + 77} Decrement N by 3 {N - 3} Double its value {N * 2}");

            Console.WriteLine("\n");
        }

        // Exercise 5.
        public static void Exercise5()
        {
            int A = 10;
            int B = 5;
            int C = 6;
            int D = 4;

            B = C;
            C = A;
            A = D;
            D = B;
        }
    }
}
