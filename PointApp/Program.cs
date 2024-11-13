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

            /*Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
            Console.WriteLine(p4);*/

            List<Point> points =
            [
                new Point(1), new Point(2),
                new Point2D(2, 3), new Point2D(3, 4),
                new Point3D(5, 6, 7), new Point3D(9, 10, 11)
            ];

            foreach (Point point in points)
            {
                Console.WriteLine(point);
            }

            MakeMove(p2);
        }

        public static void DoPrint(Point p)
        {
            Console.WriteLine(p);
        }

        public static void MakeMove(Point p)
        {
            p.Move10();
        }
    }
}
