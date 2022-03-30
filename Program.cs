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
                Console.WriteLine("Please Enter your First name");
                string input = Console.ReadLine();
                Regex r = new Regex("^[A-Z][a-z]{2,}$");
                if (r.IsMatch(input))
                {
                    Console.WriteLine("your First name is " + true);
                }
                else
                {
                    Console.WriteLine("Your First name is " + false);
                    Console.WriteLine("First Name Should Contain minimum three Character and first letter should be in uppercase!!");
                }
            }
        }
    }
}