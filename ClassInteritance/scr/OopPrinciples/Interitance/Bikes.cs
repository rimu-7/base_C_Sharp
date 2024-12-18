using System;

namespace ClassInteritance.scr.OopPrinciples.Interitance;

public class Bikes : Vehicles
{
    public int NumberOfWhiles { get; set; }

    public override void Start()
    {
        System.Console.WriteLine("Bike straing......");
    }

    public override void Stop()
    {
        System.Console.WriteLine("Bike Stoping......");
    }

}
