namespace StackToAnalyze;

public class Program
{

    public static bool IsCorrectString(string str)
    {
        var pairs = new Dictionary<char, char>();
        pairs.Add('(', ')');
        pairs.Add('[', ']');
        var stack = new Stack<char>();
        foreach (var e in str)
        {
            if (pairs.ContainsKey(e)) stack.Push(e);
            else if (pairs.ContainsValue(e))
            {
                if (stack.Count == 0 || pairs[stack.Pop()] != e) return false;
            }
            else return false;
        }
        return stack.Count == 0;
    }
    
    static void Main(string[] args)
    {
        Console.WriteLine(IsCorrectString("(([])[])"));
        Console.WriteLine(IsCorrectString("((][])"));
        Console.WriteLine(IsCorrectString("((("));
        Console.WriteLine(IsCorrectString("(x)"));
    }
}