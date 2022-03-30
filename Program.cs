using System;
using System.Text.RegularExpressions;

namespace RegexProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("\nPlease Enter Password");
                string input = Console.ReadLine();
                Regex r = new Regex("^(?=.*[A-Z])(?=.*[0-9])[0-9A-Za-z]{8,}$");
                if (r.IsMatch(input))
                {
                    Console.WriteLine("Entered Password is valid  ");
                }
                else
                {
                    Console.WriteLine("Entered Password is not valid");
                }
            }
        }
    }
}