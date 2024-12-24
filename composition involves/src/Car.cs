using System;
using ClassInteritance.scr.OopPrinciples.Composition;

namespace composition_involves.src;



public class Car
{
    private Wheels wheels = new Wheels();
    private Doors doors = new Doors();
    private Sits sits= new Sits();
    private Chassis chassis= new Chassis();
    private Engine engine= new Engine();

public void Start(){
    engine.engine();
    wheels.Rotate();
    sits.Sit();
    chassis.body();
    System.Console.WriteLine("Car started.");

}
}
