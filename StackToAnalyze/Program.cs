namespace StackToAnalyze;

public class Program
{

    public static bool IsCorrectString(string str)
    {
        var stack = new Stack<char>();
        foreach (var symbol in str)
        {
            char openBraket;
            switch (symbol)
            {
                case '(':
                case '[':
                    stack.Push(symbol);
                    break;
                case ')':
                    if (stack.Count == 0) return false;
                    openBraket = stack.Pop();
                    if (openBraket != '(') return false;
                    break;
                case ']':
                    if (stack.Count == 0) return false;
                    openBraket = stack.Pop();
                    if (openBraket != '[') return false;
                    break;
            }
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