namespace ABAX;

public class Plane : Vehicle
{
    public int vingeSpenn { get; }
    public int lasteEvne { get; }
    public int egenVekt { get; }
    public string flyKlasse { get; }

    public Plane(string registrationNumber, int engineEffect, string brand, int spenn, int last, int vekt, string klasse) : base(registrationNumber, engineEffect, brand)
    {
        vingeSpenn = spenn;
        lasteEvne = last;
        egenVekt = vekt;
        flyKlasse = klasse;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Brand: {Brand}, Regnr: {registrationNumber}, Motor: {engineEffect}kw, egenvekt: {egenVekt}kg. lasteevne: {lasteEvne}kg, Vingespenn: {vingeSpenn}meter klasse: {flyKlasse}");
    }

    public override void Run()
    {
        Console.WriteLine($"{Brand} {registrationNumber} - Flyr som fader");
    }
}