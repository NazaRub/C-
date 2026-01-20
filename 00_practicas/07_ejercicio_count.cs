List<string> historial = ["google.com", "utn.edu.ar", "github.com"];

// 1. El usuario entra a una página de hacking
historial.Add("hackers-site.org");

// 2. Queremos saber qué es lo ÚLTIMO que hizo el usuario
// Acordate: El total de elementos es Count, la última posición es Count - 1
int total = historial.Count;
string ultimaPagina = historial[total - 1]; 

Console.WriteLine($"El usuario visitó {total} páginas.");
Console.WriteLine($"ALERTA: La última ubicación fue {ultimaPagina}");

// 3. (Opcional) Borrá la primera página del historial ("google.com")
// Pista: La primera siempre es la posición 0
historial.RemoveAt(0);

Console.WriteLine("--- Historial actualizado (se borró el inicio) ---");
foreach (var sitio in historial)
{
    Console.WriteLine(sitio);
}