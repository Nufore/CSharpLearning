namespace FirstEvenNumbers;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(GetFirstEvenNumbers(3));
    }

    public static int[] GetFirstEvenNumbers(int count)
    {
        int[] numbers = new int[count];

        for (int i = 0; i < count; i++)
        {
            numbers[i] = (i + 1) * 2;
        }

        return numbers;
    }
}