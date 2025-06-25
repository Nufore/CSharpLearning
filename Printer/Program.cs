namespace Printer;

class Program
{
    static void Main(string[] args)
    {
        Print(1, 2);
        Print("a", 'b');
        Print(1, "a");
        Print(true, "a", 1);
    }

    public static void Print(params object[] args)
    {
        for (var i = 0; i < args.Length; i++)
        {
            if (i > 0)
                Console.Write(", ");
            Console.Write(args.GetValue(i));
        }

        Console.WriteLine();
    }
}