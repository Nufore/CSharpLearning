using System.Collections;

namespace SortRevertArrow;

class Program
{
    public static void Main()
    {
        var array = new[]
        {
            new Point { X = 1, Y = 0 },
            new Point { X = -1, Y = 0 },
            new Point { X = 0, Y = 1 },
            new Point { X = 0, Y = -1 },
            new Point { X = 0.01, Y = 1 }
        };
        Array.Sort(array, new ClockwiseComparer());
        foreach (Point e in array)
            Console.WriteLine("{0} {1}", e.X, e.Y);
    }

    public class Point
    {
        public double X;
        public double Y;
    }
    
    public class ClockwiseComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            var p1 = (Point)x;
            var p2 = (Point)y;
            double d1 = Math.Atan2(p1.Y, p1.X);
            if (d1 < 0) d1 += 2 * Math.PI;
            double d2 = Math.Atan2(p2.Y, p2.X);
            if (d2 < 0) d2 += 2 * Math.PI;
            return d1.CompareTo(d2);
        }
    }
}