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
                Console.WriteLine("\nPlease Enter your Email");
                string input = Console.ReadLine();
                Regex r = new Regex("^[A-Za-z]{1,10}.?[a-z]{1,15}@[a-z]{1,5}.(co|org|com).(in|co|com|us)?$");
                if (r.IsMatch(input))
                {
                    Console.WriteLine("your email is valid: " + true);
                }
                else
                {
                    Console.WriteLine("Entered email is not valid");
                }
            }
        }
    }
}