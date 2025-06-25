namespace Menu;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
    
    public static MenuItem[] GenerateMenu()
    {
        return new[] {
            ...
        }
    }
}

public class MenuItem
{
    public string Caption;
    public string HotKey;
    public MenuItem[] Items;
}