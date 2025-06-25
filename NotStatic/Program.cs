using System.Globalization;

namespace NotStatic;

class Program
{
    static void Main(string[] args)
    {
        var filter = new SuperBeautyImageFilter();
        filter.ImageName = "Paris.jpg";
        filter.GaussianParameter = 0.4;
        filter.Run();
    }
    
    public class SuperBeautyImageFilter
    {
        public string ImageName;
        public double GaussianParameter;

        public void Run()
        {
            Console.WriteLine("Processing {0} with parameter {1}", 
                ImageName, 
                GaussianParameter.ToString(CultureInfo.InvariantCulture));
            //do something useful
        }
    }
}