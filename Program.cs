using System;

class Program
{
     static void Main(string[] args)
        {
            Console.Write("Enter the height of the triangle: ");
            if (int.TryParse(Console.ReadLine(), out int height) && height > 0)
            {
                PrintTriangle(height);
            }
            else
            {
                Console.WriteLine("Please enter a valid positive integer for the height.");
            }
        }
        static void PrintTriangle(int height)
        {
           for (int i = 1; i <= height; ++i)
            {
                for (int space = 1; space <= height - i; ++space)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k != 2 * i - 1; ++k)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

        }
}