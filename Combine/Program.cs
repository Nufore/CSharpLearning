namespace Combine;

class Program
{
    static void Main(string[] args)
    {
        var ints = new[] { 1, 2 };
        var strings = new[] { "A", "B" };

        Print(Combine(ints, ints));
        Print(Combine(ints, ints, ints));
        Print(Combine(ints));
        Print(Combine());
        Print(Combine(strings, strings));
        Print(Combine(ints, strings));
    }

    static void Print(Array array)
    {
        if (array == null)
        {
            Console.WriteLine("null");
            return;
        }

        for (int i = 0; i < array.Length; i++)
            Console.Write("{0} ", array.GetValue(i));
        Console.WriteLine();
    }

    static Array Combine(params Array[] arrays)
    {
        if(arrays.Length == 0) return null;
        
        var elementType = arrays[0].GetType().GetElementType();
        int totalLenght = 0;

        foreach (var array in arrays)
        {
            if (array.GetType().GetElementType() != elementType) return null;
            totalLenght += array.Length;
        }

        var newArray = Array.CreateInstance(elementType, totalLenght);
        int index = 0;
        for (int i = 0; i < arrays.Length; i++)
        {
            for (int j = 0; j < arrays[i].Length; j++)
            {
                newArray.SetValue(arrays[i].GetValue(j), index);
                index++;
            }
        }

        return newArray;
    }
}