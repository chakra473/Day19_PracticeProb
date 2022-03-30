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
                Console.WriteLine("\nPlease Enter your Last name");
                string input = Console.ReadLine();
                Regex r = new Regex("^[A-Z][a-z]{2,}$");
                if (r.IsMatch(input))
                {
                    Console.WriteLine("your Last name is " + true);
                }
                else
                {
                    Console.WriteLine("Please enter  minimum 3 character along with first character of Last name should in upper case");
                }
            }
        }
    }
}