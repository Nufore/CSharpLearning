namespace MiddleOfThree;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(MiddleOfThree(2, 5, 4));
        Console.WriteLine(MiddleOfThree(3, 1, 2));
        Console.WriteLine(MiddleOfThree(3, 5, 9));
        Console.WriteLine(MiddleOfThree("B", "Z", "A"));
        Console.WriteLine(MiddleOfThree(3.45, 2.67, 3.12));
    }
    
    static IComparable MiddleOfThree(IComparable a, IComparable b, IComparable c)
    {
        var array = new[] { a, b, c };
        Array.Sort(array);
        return array[1];
    }
    
    static IComparable MiddleOfThreeTwo(IComparable a, IComparable b, IComparable c)
    {
        if (a.CompareTo(b) > 0)
            return b.CompareTo(c) > 0 ? b : a.CompareTo(c) > 0 ? c : a;
        return a.CompareTo(c) > 0 ? a : b.CompareTo(c) > 0 ? c : b;
    }
}