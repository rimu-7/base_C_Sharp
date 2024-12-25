using System;

namespace Solid.src.L;

// public class Squar : Rectangle
// {
//     public override double Width
//     {
//         get => base.Width;
//         set => base.Width = base.Height = value;
//     }
//     public override double Height
//     {
//         get => base.Height;
//         set => base.Height = base.Width = value;
//     }

// }

// this is not a good practice because squar has 4 equal sidelength

public class Squar : Shape
{
    public double SideLength { get; set; }
    public override double Area => SideLength * SideLength;


}