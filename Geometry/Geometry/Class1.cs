namespace Geometry;

public class Vector
{
    public double X;
    public double Y;

    public double GetLength()
    {
        return Math.Sqrt(X * X + Y * Y);
    }

    public Vector Add(Vector other)
    {
        return new Vector
        {
            X = X + other.X,
            Y = Y + other.Y
        };
    }

    public bool Belongs(Segment segment)
    {
        double crossProduct = (segment.End.X - segment.Begin.X) * (Y - segment.Begin.Y) -
                              (segment.End.Y - segment.Begin.Y) * (X - segment.Begin.X);
        if (Math.Abs(crossProduct) > 1e-10)
            return false;

        bool isXBetween = (X >= Math.Min(segment.Begin.X, segment.End.X)
                           && (X <= Math.Max(segment.Begin.X, segment.End.X)));
        bool isYBetween = (Y >= Math.Min(segment.Begin.Y, segment.End.Y)
                           && (Y <= Math.Max(segment.Begin.Y, segment.End.Y)));

        return isXBetween && isYBetween;
    }
}

public static class Geometry
{
    public static double GetLength(Vector vector)
    {
        return Math.Sqrt(vector.X * vector.X + vector.Y * vector.Y);
    }

    public static double GetLength(Segment segment)
    {
        double dx = segment.Begin.X - segment.End.X;
        double dy = segment.Begin.Y - segment.End.Y;
        return Math.Sqrt(dx * dx + dy * dy);
    }

    public static Vector Add(Vector vector1, Vector vector2)
    {
        Vector result = new Vector
        {
            X = vector1.X + vector2.X,
            Y = vector1.Y + vector2.Y
        };
        return result;
    }

    public static bool IsVectorInSegment(Vector vector, Segment segment)
    {
        double crossProduct = (segment.End.X - segment.Begin.X) * (vector.Y - segment.Begin.Y) -
                              (segment.End.Y - segment.Begin.Y) * (vector.X - segment.Begin.X);
        if (Math.Abs(crossProduct) > 1e-10)
            return false;

        bool isXBetween = (vector.X >= Math.Min(segment.Begin.X, segment.End.X)
                           && (vector.X <= Math.Max(segment.Begin.X, segment.End.X)));
        bool isYBetween = (vector.Y >= Math.Min(segment.Begin.Y, segment.End.Y)
                           && (vector.Y <= Math.Max(segment.Begin.Y, segment.End.Y)));

        return isXBetween && isYBetween;
    }
}

public class Segment
{
    public Vector Begin;
    public Vector End;

    public double GetLength()
    {
        double dx = Begin.X - End.X;
        double dy = Begin.Y - End.Y;
        return Math.Sqrt(dx * dx + dy * dy);
    }

    public bool Contains(Vector vector)
    {
        double crossProduct = (End.X - Begin.X) * (vector.Y - Begin.Y) -
                              (End.Y - Begin.Y) * (vector.X - Begin.X);
        if (Math.Abs(crossProduct) > 1e-10)
            return false;

        bool isXBetween = (vector.X >= Math.Min(Begin.X, End.X)
                           && (vector.X <= Math.Max(Begin.X, End.X)));
        bool isYBetween = (vector.Y >= Math.Min(Begin.Y, End.Y)
                           && (vector.Y <= Math.Max(Begin.Y, End.Y)));

        return isXBetween && isYBetween;
    }
}