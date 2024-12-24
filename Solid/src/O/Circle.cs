using System;

namespace Solid.src.O;

public class Circle : Shape
{
    public double Raduis { get; set; }
    public override double CalculateArea()
    {
        return Math.PI * Math.Pow(Raduis, 2);
    }
}
