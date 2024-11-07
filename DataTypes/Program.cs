namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"int: {sizeof(int) * 8}, Min: {int.MinValue}, Max: {int.MaxValue}");
            Console.WriteLine($"double: {sizeof(double) * 8}, Min: {double.MinValue}, Max: {double.MaxValue}");
            Console.WriteLine($"decimal: {sizeof(decimal) * 8}, Min: {decimal.MinValue}, Max: {decimal.MaxValue}");
        }
    }
}
