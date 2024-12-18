using ClassInteritance.scr.OopPrinciples.Interitance;

Cars cars = new Cars();

List<Vehicles> vehicles = new List<Vehicles>();

vehicles.Add(new Cars { Brands = "Toyota", Model = "Sports", Year = 2012, NumberOfDoors = 2 });
vehicles.Add(new Bikes { Brands = "Honda", Model = "Sports", Year = 2012, NumberOfWhiles = 2 });

foreach (var vehicle in vehicles)
{
    vehicle.Start();
    vehicle.Stop();
    System.Console.WriteLine("\n");
}
