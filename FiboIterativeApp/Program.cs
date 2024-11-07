namespace FiboIterativeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 20; i++) 
            {
                Console.WriteLine($"{i}, {Fibo(i)}");
            }

        }

        public static int Fibo(int n)
        {
            int a = 0;
            int b = 1;
            int c = 1;

            for (int i = 1; i < n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }

            return (n != 0) ? c : 0;
        }
    }
}
