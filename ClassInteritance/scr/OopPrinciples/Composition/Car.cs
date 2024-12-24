using System;

namespace ClassInheritance.Src.OopPrinciples.Composition
{
    public class Engine
    {
        public void Start()
        {
            Console.WriteLine("Engine starting");
        }
    }

    public class Wheels
    {
        public void Rotate()
        {
            Console.WriteLine("Wheels rotating");
        }
    }

    public class Car
    {
        private Engine engine = new Engine();
        private Wheels wheels = new Wheels();

        public void StartCar()
        {
            engine.Start();
            wheels.Rotate(); // Fixed: Call Rotate() on Wheels, not Engine.
        }
    }
}
