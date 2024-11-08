using System.Text.RegularExpressions;
namespace RegEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input1 = "hello123";
            string pattern1 = @"\d+";

            OneMatch(input1, pattern1);




            
        }

        public static void OneMatch(string input, string pattern)
        {
            Match match = Regex.Match(input, pattern);
            if (match.Success)
            {
                Console.WriteLine(match.Value);
            }
            
        }
    }
}
