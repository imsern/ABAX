using System.Security.Cryptography.X509Certificates;

namespace ABAX;

public class Car : Vehicle
{
    public int topSpeed { get; }
    public string color { get; }
    public string vehicleType { get; }
    
    public Car(string registrationNumber, int engineEffect, int topSpeed, string color, string vehicleType, string brand) : base(registrationNumber, engineEffect, brand)
    {
        this.topSpeed = topSpeed;
        this.color = color;
        this.vehicleType = vehicleType;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Brand: {Brand}, Regnr: {registrationNumber}, Motor: {engineEffect}kw, maksfart: {topSpeed}km/t. Farge: {color}, type: {vehicleType}");
    }

    public override void Run()
    {
        Console.WriteLine($"{Brand} {registrationNumber} - kjører i {topSpeed}km/t");
    }

} 