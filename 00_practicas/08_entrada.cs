List<string> puertas =["entrada", "pasillo", "laboratorio"] ;
puertas.Add("caja fuerte") ;
int total = puertas.Count ;
string ultima = puertas[total - 1 ] ;
Console.WriteLine($"se abrieron {total} puertas") ;
Console.WriteLine($"La ultima abierta fue {ultima}") ;