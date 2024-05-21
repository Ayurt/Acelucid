using System;
using System.Text.RegularExpressions;

namespace DateFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string:");
            string input = Console.ReadLine();

            string datePattern = @"(0[1-9]|1[0-2])(0[1-9]|[12]\d|3[01])\d{4}";
            Match match = Regex.Match(input, datePattern);

            if (match.Success)
            {
                Console.WriteLine("Found date: " + match.Value);
            }
            else
            {
                Console.WriteLine("No valid date found in the input string.");
            }
        }
    }
}
