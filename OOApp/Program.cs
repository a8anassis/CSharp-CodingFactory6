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
                //Lastname = "Giannoutsou"
            };

            Teacher andreas = new Teacher(1, "Andreas", "Androutsos");
        }
    }
}
