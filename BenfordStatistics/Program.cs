namespace BenfordStatistics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
    
    public static int[] GetBenfordStatistics(string text)
    {
        var statistics = new int[10];
        for (int i = 0; i < text.Length; i++)
        {
            if (i == 0 & char.IsDigit(text[i]) || (char.IsDigit(text[i]) && !char.IsDigit(text[i-1])))
            {
                int number = text[i] - '0';
                statistics[number]++;
            }
        }
        return statistics;
    }
}