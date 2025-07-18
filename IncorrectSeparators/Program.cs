﻿namespace IncorrectSeparators;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var text = "Страна Население Дата %\n    Китай: 1405023000; 24.08.2020; 17.99%\n    Индия: 1375100000 24.08.2020 17.6%\n    США: 329957441; 15.07.2020; 4.24%\n    Индонезия 266911900; 01.07.2019 3.42%\n    Пакистан - 218647040 24.08.2020; 2.8%\n    Бразилия 211950300; 24.08.2020; 2.71%\n    Нигерия 208426036; 24.08.2020; 2.67%\n    Бангладеш 171147762 24.08.2020; 2.19%\n    Россия: 146748590; 01.01.2020 1.88%\n    Мексика - 127792286, 01.07.2020, 1.64%\n    Япония 125950000; 01.03.2020, 1.61%\n    Эфиопия 112079000, 01.07.2019 1.43%\n    Филиппины 108968790, 24.08.2020; 1.39%\n    Египет 100812120, 24.08.2020 1.29%\n    Вьетнам 96208984; 01.04.2019; 1.23%\n    ДРК 86791000, 01.07.2019, 1.11%\n    Иран 84393386 24.08.2020 1.08%\n    Турция - 83154997 1.01.2020 1.06%\n    Германия - 83149300 1.10.2019 1.06%\n    Франция - 68859599; 01.01.2018, 0.88%\"";
        Console.WriteLine(ReplaceIncorrectSeparators(text));
    }
    
    
    
    public static string ReplaceIncorrectSeparators(string text)
    {
        string[] separators = new string[] { ":", ";", "-", " ", ",", "\n" };
        string[] lines = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        string newText = string.Join("\t", lines);
        return newText;
    }
}