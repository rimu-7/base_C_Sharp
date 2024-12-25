using Solid.src.I;
using Solid.src.L;
// var rect = new Rectangle();

// rect.Width = 10;
// rect.Height = 10;

// System.Console.WriteLine("The Expected area Rectangle = 100");
// System.Console.WriteLine("The calculated area of Rectangle = "+rect.Area);


// var squar = new Squar();

// squar.Height = 5;

// System.Console.WriteLine("The Expected area Squar = 25");
// System.Console.WriteLine("The calculated area of Squar = "+squar.Area);



// Shape rectangle = new Rectangle{ Height = 10, Width= 10};
// System.Console.WriteLine($"Area of rectangle: {rectangle.Area}");

// Shape squar = new Squar{SideLength= 5};
// System.Console.WriteLine($"Area of squar: {squar.Area}");

var circle = new Circle();
circle.Radius = 10;
System.Console.WriteLine(circle.Area());

var circle3D = new Sphere();

circle3D.Radius = 15;
System.Console.WriteLine(circle3D.Area());
System.Console.WriteLine(circle3D.Volume());
