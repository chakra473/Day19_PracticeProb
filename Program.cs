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
                Console.WriteLine("\nPlease Enter your mobile Number");
                string input = Console.ReadLine();
                Regex r = new Regex("^[0-9]{2} [1-9][0-9]{9}$");
                if (r.IsMatch(input))
                {
                    Console.WriteLine("your Mobile number is valid  ");
                }
                else
                {
                    Console.WriteLine("Entered Mobile Number is not valid is not valid");
                }
            }
        }
    }
}