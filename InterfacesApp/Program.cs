using InterfacesApp.Model;

namespace InterfacesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMoveable p2 = new Point2D()
            {
                X = 10,
                Y = 20
            };

            MovingSpace movingSpace = new(p2);
            movingSpace.MakeMove15();

            p2.Move10();
            Console.WriteLine(p2);
        }
    }
}
