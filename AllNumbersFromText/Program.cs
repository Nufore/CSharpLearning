namespace AllNumbersFromText;

class Program
{
    //SkipSpaces пропускает все пробельные символы в text, начиная с позиции pos.
    //В конце pos оказывается установлен в первый непробельный символ.
    public static void SkipSpaces(string text, ref int pos)
    {
        while (pos < text.Length && char.IsWhiteSpace(text[pos]))
            pos++;
    }

    //ReadNumber пропускает все цифры в text, начиная с позиции pos, а затем возвращает все пропущенные символы.
    //В конце pos оказывается установлен в первый символ не цифру.
    public static string ReadNumber(string text, ref int pos)
    {
        var start = pos;
        while (pos < text.Length && char.IsDigit(text[pos]))
            pos++;
        return text.Substring(start, pos - start);
    }

    //Функция, которая читает все числа из строки и выводит их, разделяя единственным пробелом.
    public static void WriteAllNumbersFromText(string text)
    {
        var pos = 0;
        while (true)
        {
            SkipSpaces(text, ref pos);
            if (pos == text.Length) break;
            var num = ReadNumber(text, ref pos);
            if (num == "") pos++;
            else Console.Write(num + " ");
        }

        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        string text = "ab c12d 3478";
        WriteAllNumbersFromText(text);
    }
}