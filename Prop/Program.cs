namespace Prop;

class Program
{
    public static void Check()
    {
        var book = new Book();
        book.Title = "Structure and interpretation of computer programs";
        Console.WriteLine(book.Title);
    }

    static void Main(string[] args)
    {
        Check();
    }
}

public class Book
{
    public string Title { get; set; }
}