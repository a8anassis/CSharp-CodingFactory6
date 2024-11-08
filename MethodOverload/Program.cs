namespace MethodOverload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static void PrintNums(int intVal, float floatVal)
        {
            Console.WriteLine(intVal + " -- " + floatVal);
        }

        public static void PrintNums(float intVal, float floatVal)
        {
            Console.WriteLine(intVal + " -- " + floatVal);
        }
    }
}
    