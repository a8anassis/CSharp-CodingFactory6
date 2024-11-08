namespace ParamsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            result = Add(1, 7, 8, 9);
            Console.WriteLine(result);

            result = Add(1, 7, 8, 9, 5, 5, 5);
            Console.WriteLine(result);
        }

        /// <summary>
        /// A type of overloading.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int Add(params int[] nums)
        {
            int sum = 0;
            foreach (int el in nums)
            {
                sum += el;
            }
            return sum;
        }
    }
}
