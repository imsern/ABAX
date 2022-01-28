namespace ABAX;

public class Boat : Vehicle
{
    public int topSpeed { get; }
    public int bruttoTonnasje { get; }

    public Boat(string registrationNumber, int engineEffect, string brand, int brTonn, int tSpeed) : base(registrationNumber, engineEffect, brand)
    {
        topSpeed = tSpeed;
        bruttoTonnasje = brTonn;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Brand: {Brand}, Regnr: {registrationNumber}, Motor: {engineEffect}kw, maksfart: {topSpeed}knop. Bruttotonnasje: {bruttoTonnasje}kg");
    }

    //public override void Run()
    //{
    //    Console.WriteLine($"{Brand} {registrationNumber} - kjører i {topSpeed}knop");
    //}

}