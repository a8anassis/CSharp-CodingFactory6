using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointMonolithic.Model
{
    internal class Point : IEquatable<Point>, IComparable<Point>
    {
        public int X { get; set; }
        private static readonly List<Point?> _points = new();
        public static List<Point?> Points { get { return new List<Point?>(_points); } }

        public Point() { }

        public Point(int x)
        {
            X = x;
        }

        public bool Equals(Point? other)
        {
            if (other is null) return false;
            return CompareTo(other) == 0;

        }

        public int CompareTo(Point? other)
        {
            return X - other!.X;
            //if (X < other!.X) return -1;
            //if (X > other.X) return 1;
            //if (X == other!.X) return 0;
        }

        public override bool Equals(object? obj)
        {
            return (obj is Point other) && Equals(other);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X);
        }

        public override string? ToString()
        {
            return $"{{{X}}}";
        }

        public static bool operator >(Point? p1, Point? p2)
        {
            if (p1 is null || p2 is null) return false;
            return p1.X > p2.X;
        }

        public static bool operator <(Point? p1, Point? p2)
        {
            if (p1 is null || p2 is null) return false;
            return p1.X < p2.X;
        }

        public static bool operator >=(Point? p1, Point? p2)
        {
            if (p1 is null || p2 is null) return false;
            return p1.X >= p2.X;
        }

        public static bool operator <=(Point? p1, Point? p2)
        {
            if (p1 is null || p2 is null) return false;
            return p1.X <= p2.X;
        }

        public static bool operator ==(Point? p1, Point? p2)
        {
            if (p1 is null || p2 is null) return false;
            return p1.X == p2.X;
        }

        public static bool operator !=(Point? p1, Point? p2)
        {
            if (p1 is null || p2 is null) return false;
            return p1.X != p2.X;
        }

        /*
         * CRUD API
         */
        
        public void Insert()
        {
            _points.Add(this);
        }

        public bool Update(Point? point)
        {
            int positionToUpdate = GetPointPosition();
            if (positionToUpdate == -1) return false;
            _points[positionToUpdate] = point;
            return true;
        }

        public Point? Delete()
        {
            int positionToDelete = GetPointPosition();
            if (positionToDelete == -1) return null;
            Point? pointToReturn = _points[positionToDelete];
            _points.RemoveAt(positionToDelete);
            return pointToReturn;
        }

        public Point? GetOnePoint()
        {
            return _points.Contains(this) ? _points[GetPointPosition()] : null;
        }

        private int GetPointPosition()
        {
            return _points.IndexOf(this);
        }

        /*
         * Service API 
         */

        public void InsertPoint()
        {
            Insert();
        }

        public Point? UpdatePoint(Point? point)
        {
            if (Update(point)) return point;
            return null;
        }

        public Point? DeletePoint()
        {
            return Delete();
        }

        public Point? GetPoint()
        {
            return GetOnePoint();
        }

        public static List<Point?> GetAllPoints()
        {
            return new List<Point?>(_points);
        }
    }
}
