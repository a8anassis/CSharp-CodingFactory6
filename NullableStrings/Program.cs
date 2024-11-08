namespace NullableStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1;
            string? s2;

            Console.WriteLine("Please insert s1 and s2");
            s1 = Console.ReadLine()!;
            s2 = Console.ReadLine();

            if (s2 != null)
            {
                if ((s1.Equals("Coding")) && (s2.Equals("Factory")))
                {

                }
            }
            
        }

        public static string? GetUpperCaseString()
        {
            string? s1;

            Console.WriteLine("Enter a string");
            s1 = Console.ReadLine();

            return s1?.ToUpper();
        }
    }
}
