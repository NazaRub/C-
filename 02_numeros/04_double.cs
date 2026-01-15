// como el INT tiene limites minimos y maximos, veremos otros TYPES que puedan usarse en caso de sobrepasar esos limites
 // OPERACIONES DOUBLE
double a = 19;
double b = 23;
double c = 8;
double d = (a + b) / c;
Console.WriteLine(d);

double max = double.MaxValue;
double min = double.MinValue;
Console.WriteLine($"The range of double is {min} to {max}");
double third = 1.0 / 3.0;
Console.WriteLine(third);