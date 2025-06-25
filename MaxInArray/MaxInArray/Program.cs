using System.Diagnostics.Tracing;

namespace MaxInArray;

class Program
{
    public static void Main()
    {
        Console.WriteLine(Max(new int[0]));
        Console.WriteLine(Max(new[] { 3 }));
        Console.WriteLine(Max(new[] { 3, 1, 2 }));
        Console.WriteLine(Max(new[] { "A", "B", "C" }));
    }

    static T Max<T>(T[] source) where T : IComparable<T>
    {
        if (source.Length == 0)
            return default(T);

        T max = source[0];
        for (int i = 1; i < source.Length; i++)
        {
            if (source[i].CompareTo(max) > 0)
            {
                max = source[i];
            }
        }

        return max;
    }
}