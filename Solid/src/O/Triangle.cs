using System;

namespace Solid.src.O;

public class Triangle : Shape
{
    public double Length1 { get; set; }
    public double Length2 { get; set; }
    public double Length3 { get; set; }

    public override double CalculateArea()
    {
        double S = (Length1 + Length2 + Length3) / 2;
        return Math.Sqrt(S * (S-Length1) * (S - Length2 ) * (S - Length3));
    }
}
