using System.Text;

namespace StBuilder;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var commands = new string[] { "push Привет! Это снова я! Пока!", "pop 5" };
        Console.WriteLine(ApplyCommands(commands));
    }

    private static string ApplyCommands(string[] commands)
    {
        var builder = new StringBuilder();

        foreach (var command in commands)
        {
            var spaceIndex = command.IndexOf(' ');
            var commandName = command.Substring(0, spaceIndex);
            var otherText = command.Substring(spaceIndex + 1);
            if (commandName == "push")
            {
                builder.Append(otherText);
            }
            else
            {
                int symbolCount = int.Parse(otherText);
                builder.Remove(builder.Length - symbolCount, symbolCount);
            }
        }
        
        return builder.ToString();
    }
}