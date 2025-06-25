namespace Recursion;

class Program
{
    static void Main(string[] args)
    {
        char[] items = new char[] { 'a', 'b', 'c', 'd', 'e', 'f' };;
        WriteReversed(items);
    }

    public static void WriteReversed(char[] items, int startIndex = 0)
    {
        if (startIndex == items.Length)
            return;
        WriteReversed(items, startIndex + 1);
        Console.Write(items[startIndex]);
    }
}