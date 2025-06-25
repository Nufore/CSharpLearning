namespace SubArray;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
    
    public static int FindSubarrayStartIndex(int[] array, int[] subArray)
    {
        for (var i = 0; i < array.Length - subArray.Length + 1; i++)
            if (ContainsAtIndex(array, subArray, i))
                return i;
        return -1;
    }

    public static bool ContainsAtIndex(int[]  array, int[] subArray, int index)
    {
        foreach (var item in subArray)
        {
            if (item == array[index]) index++;
            else return false;
        }
        return true;
    }
}