namespace ABAX;

public class Vehicle : IVehicle
{
    public string Brand { get; }
    public string registrationNumber { get; set; }
    public int engineEffect { get; set; }
    public static List<Counter> countVehicle = new();

    public Vehicle(string registrationNumber, int engineEffect, string brand)
    {
        this.registrationNumber = registrationNumber;
        this.engineEffect = engineEffect;
        this.Brand = brand;
    }

    public void CompareVehicle(Vehicle v)
    {
        var index = countVehicle.FindIndex(x => x.car.registrationNumber == v.registrationNumber);
        if (index != -1)
        {
            countVehicle[index].count++;
        }
        else
        {
            countVehicle.Add(new Counter(v, 1));
        }
    }

    public virtual void Run()
    {
        
    }

    public virtual void PrintInfo()
    {
        
    }
}