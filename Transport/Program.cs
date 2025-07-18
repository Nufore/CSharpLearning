﻿namespace Transport;

class Transport
{
    public double Velocity;
    public double KilometerPrice;
    public int Capacity;
}

class CombustionEngineTransport : Transport
// это двоеточие обозначает наследование
{
    public double EngineVolume;
    public double EnginePower;
}

enum ControlType
{
    Forward,
    Backward
}

class Car : CombustionEngineTransport
{
    public ControlType Control;
}

class Program
{
    static void Main()
    {
        // var c = new Car();
        // c.Control = ControlType.Backward; //это собственное поле класса Car
        // c.EnginePower = 100; // это поле унаследовано от CombustionEngineTransport
        // c.Capacity = 4; // это поле унаследовано от Transport
        
        Car car = new Car();
        Transport carAsT = (Transport)car;
        Car car1 = (Car)carAsT;
        
        car1.Control = ControlType.Forward;
    }
}