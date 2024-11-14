using PointMonolithic.Model;

namespace PointMonolithic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new() { X = 1 };
            Point p2 = new() { X = 2 };
            Point p3 = new() { X = 3 };

            p1.InsertPoint();
            p2.InsertPoint();
            p3.InsertPoint();


            Point? deletedPoint = p3.DeletePoint();
            p3.UpdatePoint(new Point { X = 55 });

            foreach (Point? p in Point.GetAllPoints())
            {
                Console.WriteLine(p);
            }

            Point.GetAllPoints().ForEach(p => Console.WriteLine(p));
            Point.Points.ForEach(Console.WriteLine);
        }
    }
}
