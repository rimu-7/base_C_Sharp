using System;

namespace ClassInteritance.scr.OopPrinciples.Interitance;

public class Vehicles
{
    public string Brands { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public virtual void Start()
    {
        System.Console.WriteLine("Vehicle straing......");
    }

    public virtual void Stop(){
        System.Console.WriteLine("Vehicle Stoping......");
    }


}
