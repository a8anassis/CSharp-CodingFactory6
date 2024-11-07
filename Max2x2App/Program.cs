namespace Max2x2App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum;
            int maxSum = int.MinValue;
            int row = 0;
            int column = 0;

            int[,] matrix =
            {
                {1, 2, 3, 4, 5, 6 },
                {2, 3, 44, 5, 6, 7 },
                {3, 4, 5, 6, 7, 8 },
                {4, 5, 6, 7, 8, 9 }
            };

            for (int i = 0;  i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    sum = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        row = i;
                        column = j;
                    }
                }
            }
            Console.WriteLine($"Max Sum: {maxSum}, Row: {row}, Column: {column}");
        }
    }
}
