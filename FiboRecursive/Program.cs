namespace FiboRecursive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"{i,3}\t{Fibo(i),10}");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int Fibo(int n)
        {
            if (n <= 1)
            {
                return n;
            }

            return Fibo(n - 1) + Fibo(n-2);
        }
    }
}
