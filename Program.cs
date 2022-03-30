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
                Console.WriteLine("\nPlease Enter your email");
                string input = Console.ReadLine();
                Regex r = new Regex("^[A-Za-z0-9.+-]{1,}[a-zA-Z0-9]@[a-z0-9]{1,}.(co|org|com|in|us|net|au|com.com|com.au)$");
                if (r.IsMatch(input))
                {
                    Console.WriteLine("Entered Email is valid  ");
                }
                else
                {
                    Console.WriteLine("Entered Email is not valid");
                }
            }
        }
    }
}