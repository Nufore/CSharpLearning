namespace Passwords;

class Program
{
    static void Main(string[] args)
    {
        WriteAllWordsOfSize(1);
        Console.WriteLine();
        WriteAllWordsOfSize(2);
        Console.WriteLine();
        WriteAllWordsOfSize(0);
        Console.WriteLine();
        WriteAllWordsOfSize(4);
    }
    
    static void WriteAllWordsOfSize(int size)
    {
        MakeSubsets(new char[size]);
    }
    
    static void MakeSubsets(char[] subset, int position = 0)
    {
        if (position == subset.Length)
        {
            Console.WriteLine(new string(subset));
            return;
        }
        subset[position] = 'a';
        MakeSubsets(subset, position + 1);
        subset[position] = 'b';
        MakeSubsets(subset, position + 1);
        subset[position] = 'c';
        MakeSubsets(subset, position + 1);
    }
}