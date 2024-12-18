using System;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassInteritance.scr.OopPrinciples.Interitance;

public class Cars : Vehicles
{
    public int NumberOfDoors{get; set; }
    public int NumberOfWhiles{get; set;}

    public override void Start()
    {
        System.Console.WriteLine("Cars straing......");
    }

    public override void Stop(){
        System.Console.WriteLine("Cars Stoping......");
    }

}
