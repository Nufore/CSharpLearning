namespace RightSequence;

class Program
{
    static void Main(string[] args)
    {
        string input = "{[()]}";

        Dictionary<char, char> GetBracketPairs()
        {
            return new Dictionary<char, char>()
            {
                { ')', '(' },
                { ']', '[' },
                { '}', '{' }
            };
        }

        bool IsValid(string s)
        {
            var stack = new Stack<char>();
            var pairs = GetBracketPairs();

            foreach (var c in s)
            {
                if (pairs.ContainsValue(c))
                {
                    stack.Push(c);
                }
                else if (pairs.ContainsKey(c))
                {
                    if (stack.Count == 0 || stack.Pop() != pairs[c]) return false;
                }
            }

            return stack.Count == 0;
        }

        Console.WriteLine(IsValid(input));
    }
}