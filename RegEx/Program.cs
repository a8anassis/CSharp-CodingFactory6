using System.Text.RegularExpressions;
namespace RegEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input1 = "hello123";
            string pattern1 = @"\d+";

            GetOneMatch(input1, pattern1);

            string input2 = "price1: $10, price2: $20, price3: $30";
            string pattern2 = @"\$\d+";

            GetMultipleMatches(input2, pattern2);

            string input3 = "Phone number is: 697-999-9990";
            string pattern3 = @"\d";

            Replaces(input3, pattern3);

            string input4 = "red,white,green";
            string pattern4 = @",";

            Split(input4 , pattern4);


        }

        public static void GetOneMatch(string input, string pattern)
        {
            Match match = Regex.Match(input, pattern);
            if (match.Success)
            {
                Console.WriteLine(match.Value);
            }
            
        }

        public static void GetMultipleMatches(string input, string pattern)
        {
            MatchCollection matches = Regex.Matches(input, pattern);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }

        public static void Replaces(string input, string pattern)
        {
            string replaced = Regex.Replace(input, pattern, "*");
            Console.WriteLine(replaced);
        }

        public static void Split(string input, string pattern)
        {
            string[] tokens = Regex.Split(input, pattern);
            foreach (string token in tokens)
            {
                Console.WriteLine(token);
            }
        }
    }
}
