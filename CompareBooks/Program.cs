namespace CompareBooks;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

class Book : IComparable
{
    public string Title;
    public int Theme;
    
    public int CompareTo(object? obj)
    {
        var book = (Book)obj;
        if (Theme < book.Theme) return -1;
        else if (Theme == book.Theme) return Title.CompareTo(book.Title);
        else return 1;
    }
}