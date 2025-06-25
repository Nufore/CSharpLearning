namespace Contacts;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
    
    private static Dictionary<string, List<string>> OptimizeContacts(List<string> contacts)
    {
        var dictionary = new Dictionary<string, List<string>>();

        foreach (var contact in contacts)
        {
            string[] data = contact.Split(":");
            string f2 = string.Empty;
            if (data[0].Length < 2) f2 = data[0];
            else f2 = data[0].Substring(0, 2);
            if (!dictionary.ContainsKey(f2)) dictionary[f2] =  new List<string>();
            dictionary[f2].Add(contact);
        }

        return dictionary;
    }
}