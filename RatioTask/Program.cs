using System.Globalization;

namespace RatioTask;

class Program
{
    public static void Check(int num, int den)
    {
        var ratio = new Ratio(num, den);
        Console.WriteLine("{0}/{1} = {2}",
            ratio.Numerator, ratio.Denominator,
            ratio.Value.ToString(CultureInfo.InvariantCulture));
        ratio.Value = 1;
    }

    static void Main(string[] args)
    {
        Check(1, 2);
    }
}

public class Ratio
{
    public Ratio(int num, int den)
    {
        Numerator = num;
        if (den <= 0) throw new ArgumentNullException();
        Denominator = den;
        Value = (double)num / (double)den;
    }

    public readonly int Numerator; //числитель
    public readonly int Denominator; //знаменатель
    public readonly double Value;
}