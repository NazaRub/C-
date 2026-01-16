var pt = (X: 1, Y: 2) ;
var slope = (double)pt.Y / (double)pt.X ;
Console.WriteLine($"A line from the origin to the point {pt} has a slope of {slope}.") ;
pt.X = pt.X + 5;
Console.WriteLine($"The point is now at {pt}.");
/*
Las tuplas son una herramienta fantástica, pero tienen un propósito muy específico. No las saltees, porque te van a ahorrar mucho trabajo, aunque no las uses en cada línea de código.

Imagina que tienes un método que calcula dos cosas a la vez, por ejemplo, el daño mínimo y el daño máximo de un arma.

Sin tuplas: Tendrías que crear una class o un struct solo para devolver esos dos números, o usar parámetros raros.

Con tuplas: Puedes empaquetar varios valores en una sola variable "al vuelo", sin tanta ceremonia. 
*/
// Creando una tupla con nombre y daño
var ataqueFuerte = (Nombre: "Explosión", Danio: 50);

Console.WriteLine($"Usaste {ataqueFuerte.Nombre} y sacaste {ataqueFuerte.Danio}");