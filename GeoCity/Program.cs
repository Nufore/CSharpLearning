﻿using System.Globalization;

namespace GeoCity;

class Program
{
    public static void Main()
    {
        var city = new City();
        city.Name = "Ekaterinburg";
        city.Location = new GeoLocation();
        city.Location.Latitude = 56.50;
        city.Location.Longitude = 60.35;
        Console.WriteLine("I love {0} located at ({1}, {2})", 
            city.Name, 
            city.Location.Longitude.ToString(CultureInfo.InvariantCulture),
            city.Location.Latitude.ToString(CultureInfo.InvariantCulture));
    }
}

class City
{
    public string Name { get; set; }
    public GeoLocation Location { get; set; }
}

class GeoLocation
{
    public double Latitude { get; set; }
    public double Longitude { get; set; }
}
