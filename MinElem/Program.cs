namespace MinElem;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Min(new[] { 3, 6, 2, 4 }));
        Console.WriteLine(Min(new[] { "B", "A", "C", "D" }));
        Console.WriteLine(Min(new[] { '4', '2', '7' }));
    }

    public static object Min(Array args)
    {
        Array.Sort(args);
        return args.GetValue(0);
    }
}