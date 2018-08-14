using System;

class Vehicle
{
    public Vehicle(int p, int f, int m)
    {
        passengers = p;
        FuelCap = f;
        Mpg = m;
    }

    public int Range()
    {
        return Mpg * FuelCap;
    }

    public double FuelNeeded(int miles)
    {
        return (double)miles / Mpg;
    }

    public int passengers { get; protected set; }
    public int FuelCap { get; protected set; }
    public int Mpg { get; protected set; }
}

class Truck : Vehicle
{
    public Truck(int p, int f, int m, int c) : base(p, f, m)
    {
        CargoCap = c;
    }

    public int CargoCap { get; protected set; }
}

class TruckDemo
{
    static void Main()
    {
        Truck semi = new Truck(2, 200, 7, 44000);
        Truck pickup = new Truck(3, 28, 15, 2000);

        double gallons;
        int dist = 252;

        Console.WriteLine("Semi can carry {0} pounds.", semi.CargoCap);
    }

}