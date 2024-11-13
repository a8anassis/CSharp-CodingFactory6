using PointApp.Model;


namespace PointApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1);
            Point p2 = new Point2D(1, 2);
            Point p3 = new Point3D(1, 2, 3);

            Point p4 = new Point3D()
            {
                X = 3,
                Y = 4,
                Z = 5
            };

            p1.X = 20;
            ((Point2D)p2).Y = 30;
            p3.X = 40;

            p4.Move10();
            p1.Move10();

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
            Console.WriteLine(p4);


        }
    }
}
