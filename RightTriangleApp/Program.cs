namespace RightTriangleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double EPSILON = 0.000005;
            //double a = 0.0;
            //double b = 0.0;
            //double c = 0.0;
            bool isRight;

            Console.WriteLine("Please enter a, b, c");
            if (!double.TryParse(Console.ReadLine(), out double a))
            {
                Console.WriteLine("Format Error. a must be double.");
            }
            if (!double.TryParse(Console.ReadLine(), out double b))
            {
                Console.WriteLine("Format Error. b must be double.");
            }
            if (!double.TryParse(Console.ReadLine(), out double c))
            {
                Console.WriteLine("Format Error. c must be double.");
            }

            isRight = Math.Abs(a * a - b * b - c * c) <= EPSILON;
            Console.WriteLine("The triangle is{0}right", (isRight) ? " ": " not ");
        }
    }
}
