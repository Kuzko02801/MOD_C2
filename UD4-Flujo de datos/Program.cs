using System;
using System.Collections.Generic;

namespace UD4_Flujo_de_datos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        // Exercise 1.
        public static void Exercise1()
        {
            Console.WriteLine("Exercise 1");

            int A = 1;
            int B = 2;
            int C = 3;
            int D = A + B + C;

            Console.WriteLine($"Sum of all variables: {D}");
        }

        // Exercise 2.
        public static void Exercise2()
        {
            Console.WriteLine("Exercise 2");

            Console.WriteLine("Please type a name.");
            string name = Console.ReadLine();

            Console.WriteLine("Please type a city.");
            string city = Console.ReadLine();

            Console.WriteLine($"Hello {name} welcome to {city}");

            Console.WriteLine("\n");
        }

        // Exercise 3.
        public static void Exercise3()
        {
            Console.WriteLine("Exercise 3");

            Console.WriteLine("Please type a name.");
            string name = Console.ReadLine();

            Console.WriteLine("Please type an age.");
            
            int age;
            
            try
            {
                age = Int32.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Please type a number.");
                return;
            }

            Console.WriteLine($"You are {name} and you are {age} old");

            Console.WriteLine("\n"); 
        }

        // Exercise 4.
        public static void Exercise4()
        {
            int A;
            int B;

            try
            {
                A = Int32.Parse(Console.ReadLine());
                B = Int32.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("A and B must be numbers.");
                return;
            }

            Console.WriteLine(A > B ? "A is grater than B" : "B is greater than A");

            Console.WriteLine("\n");
        }

        // Exercise 5.
        public static void Exercise5()
        {
            List<string> days = new List<string>();

            days.Add("monday");
            days.Add("tuesday");
            days.Add("wednesday");
            days.Add("thursday");
            days.Add("friday");
            days.Add("saturday");
            days.Add("sunday");

            Console.WriteLine("Please type the day of the week.");
            string day;
            try
            {
                day = Console.ReadLine().ToLower();
            }
            catch (Exception e)
            {
                Console.WriteLine("Please type a string of text.");
                return;
            }
            if (days.Contains(day)) {
                if (day.Equals("saturday") || day.Equals("sunday"))
                    Console.WriteLine("Its weekend.");
                else
                    Console.WriteLine("Its not weekend");
            }
        }

        // Exercise 6.
        public static void Exercise6()
        {
            Console.WriteLine("Exercise 6.");
            
            
            double price;
            string payMethod;
            
            try
            {
                Console.WriteLine("Please type a number.");
                price = Int32.Parse(Console.ReadLine());
                if (price < 1.0)
                    throw new ArgumentException();

            } catch(Exception e)
            {
                Console.WriteLine("Type a positive number.");
                return;
            }

            try
            {

                Console.WriteLine("Please type a pay method.");
                payMethod = Console.ReadLine();
                int account;
                switch (payMethod)
                {
                    case "cash":
                        Console.WriteLine($"You will pay {price} with {payMethod}");
                        break;
                    case "card":
                        Console.WriteLine("Please type an account number.");
                        account = Int32.Parse(Console.ReadLine());
                        Console.WriteLine($"You will pay {price} with {payMethod} with account number {account}");
                        break;
                    default:
                        Console.WriteLine("Type a valid pay method.");
                        break;
                }
            } catch (Exception e)
            {
                Console.WriteLine("Type a valid account number.");
                return;
            }

        }

        // Exercise 7.
        public static void Exercise7()
        {
            Console.WriteLine("Exercise 7");
            for(int i = 1; i < 101; i++)
            {
                Console.WriteLine(i);
            }
        }

        // Exercise 8.
        public static void Exercise8()
        {
            Console.WriteLine("Exercise 8");
            int i = 1;
            while(i < 101)
            {
                Console.WriteLine(i++);                
            }
        }

        // Exercise 9.
        public static void Exercise9()
        {
            Console.WriteLine("Exercise 9");
            int i = 1;
            while (i < 101)
            {
                
                if(i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
        }

        // Exercise 10.
        public static void Exercise10()
        {
            Console.WriteLine("Exercise 10");
            int i = 1;
            while (i < 101)
            {

                if (i % 2 == 0 || i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
        }
    }
}
