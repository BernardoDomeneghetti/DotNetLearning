using System.Text.RegularExpressions;

namespace POC_Regex
{
    public class Program
    {
        public static void Main()
        {
            var scrambledText = "aaaaaaaaaaaaaq";

            var match = Regex.IsMatch(scrambledText, @"^(.)\1{9,}$");

            if(match)
                Console.WriteLine("match");      
        }
    }
}