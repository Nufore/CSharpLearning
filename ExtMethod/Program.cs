﻿namespace ExtMethod;

class Program
{
    static void Main(string[] args)
    {
        
        
        var arg1 = "100500";
        Console.Write(arg1.ToInt() + "42".ToInt()); // 100542
    }
}

public static class StringExtensions
{
    public static int ToInt(this string str)
    {
        return int.Parse(str);
    }
}