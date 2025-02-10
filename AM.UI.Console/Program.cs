using AM.Core.Domain;

Console.WriteLine("Hello, World!");

Plane plane = new();

plane.Type = PlaneType.Boing;
plane.Capacity = 180;
plane.ManuFactureDate = new DateTime(2015, 5, 20);
plane.PlaneId = 1;

Plane plane2 = new (PlaneType.Airbus, 220, new DateTime(2020, 8, 15));
Plane plane3 = new Plane
{
    Type = PlaneType.Airbus,

};


Console.WriteLine(plane);
Console.WriteLine(plane2);
