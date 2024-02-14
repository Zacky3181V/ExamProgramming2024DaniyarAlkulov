using Geometry;

var a = new Point();
var b = new Point(2.5);
var c = new Point(2.5, 3.0);

Console.WriteLine($"{a.X()} {a.Y()}") ;
Console.WriteLine($"{b.X()} {b.Y()}");
Console.WriteLine($"{c.X()} {c.Y()}");

a.ReflectX(5);
a.ReflectY(10);

b.ReflectY(5);

c.ReflectX(5);
Console.WriteLine("\n");
Console.WriteLine($"{a.X()} {a.Y()}");
Console.WriteLine($"{b.X()} {b.Y()}");
Console.WriteLine($"{c.X()} {c.Y()}");
Console.WriteLine("\n");

var a1 = new ColourfulPoint(5.0, 3.0, 0);
Console.WriteLine(a1.X());
Console.WriteLine(a1.Y());
Console.WriteLine(a1.Colour);
