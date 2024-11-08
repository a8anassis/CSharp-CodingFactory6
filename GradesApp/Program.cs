namespace GradesApp
{
    /// <summary>
    /// Λαμβάνει ως είσοδο total marks και courses count
    /// και υπολογίζει τον μέσο όρο καθώς και παρουσιάζει
    /// αντίστοιχους χαρακτηρισμούς (Άριστα, Πολύ καλά, κλπ.)
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int average;

            Console.WriteLine("Please enter total marks and courses count");

            if (!int.TryParse(Console.ReadLine(), out int totalMarks))
            {
                Console.WriteLine("Error. Format mismatch.");
            }

            if (totalMarks < 0)
            {
                Console.WriteLine("Total marks must not be negative number.");
                Environment.Exit(1);
            }

            if (!int.TryParse(Console.ReadLine(), out int coursesCount))
            {
                Console.WriteLine("Error. Format mismatch.");
            }

            if (coursesCount < 0)
            {
                Console.WriteLine("Courses count must not be negative number.");
                Environment.Exit(1);
            }

            average = totalMarks / coursesCount;
             
            if (average > 10)
            {
                Console.WriteLine("Average must not be greater than 10");
            }

            switch (average)
            {
                case >= 8:
                    Console.WriteLine($"Excellent: {average}");
                    break;
                case >= 6:
                    Console.WriteLine($"Very Good: {average}");
                    break;
                case >= 5:
                    Console.WriteLine($"Good: {average}");
                    break;
                default:
                    Console.WriteLine($"Failure: {average}");
                    break;
            }
        }
    }
}
