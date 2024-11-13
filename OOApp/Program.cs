using OOApp.Model;

namespace OOApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher alice = new Teacher();
            Teacher bob = new();    // >= C#9
            var costas = new Teacher();

            Teacher anna = new Teacher()    // Object Initializer
            {
                Id = 1,
                Firstname = "Anna"
                // Lastname = "Giannoutsou"
            };

            Teacher bob2 = new Teacher(1, "Bob", "Dylan", SchoolType.KEK);

            anna.Firstname = "Georgia";
            Console.WriteLine(anna.Firstname);

            Teacher andreas = new Teacher(1, "Andreas", "Androutsos", SchoolType.KEK);
        }
    }
}
