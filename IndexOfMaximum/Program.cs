namespace IndexOfMaximum;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
    
    public static int MaxIndex(double[] array)
    {
        if (array.Length == 0) return -1;
        
        double max = array[0];
        int maxIndex = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                maxIndex = i;
            }
        }
        
        return maxIndex;
    }
}