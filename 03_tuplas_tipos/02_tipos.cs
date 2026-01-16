Point pt3 = new Point(1, 1);
var pt4 = pt3 with { Y = 10 };
Console.WriteLine($"The two points are {pt3} and {pt4}");
public record Point (int X, int Y) ;

/*
¿Qué significa esto en humano? Le estás diciendo a C#: "De ahora en adelante, existe un nuevo tipo de 'caja' llamada Point. Cada vez que cree un Point, adentro va a tener obligatoriamente un número entero llamado X y otro llamado Y".
*/