// 1. VARIABLES INICIALES (El "estado" del juego)
int vidaHeroe = 100;
int manaHeroe = 50; // Agregamos maná

int vidaVillano = 80;
int ataqueVillano = 20;

// 2. EL BUCLE DE COMBATE
// Mientras ambos estén vivos, la pelea sigue
while (vidaHeroe > 0 && vidaVillano > 0)
{
    Console.WriteLine("\n================================");
    Console.WriteLine($"TU ESTADO: Vida: {vidaHeroe} | Maná: {manaHeroe}");
    Console.WriteLine($"VILLANO:   Vida: {vidaVillano}");
    Console.WriteLine("================================\n");

    // --- TURNO DEL HÉROE ---
    Console.WriteLine("Elije tu ataque:");
    Console.WriteLine("1 - Espadazo (20 daño - 0 maná)");
    Console.WriteLine("2 - Hechizo de Fuego (35 daño - 20 maná)");
    
    // Leemos la opción del usuario como texto (string)
    string eleccion = Console.ReadLine(); 

    if (eleccion == "1")
    {
        Console.WriteLine("¡Atacas con tu espada!");
        vidaVillano -= 20;
    }
    else if (eleccion == "2")
    {
        // Verificamos si tiene maná suficiente
        if (manaHeroe >= 20)
        {
            Console.WriteLine("¡Lanzas una bola de fuego!");
            vidaVillano -= 35;
            manaHeroe -= 20; // Gastamos el maná
        }
        else
        {
            Console.WriteLine("¡No tienes suficiente maná! Pierdes el turno intentando concentrarte.");
        }
    }
    else
    {
        Console.WriteLine("Te confundiste de comando y no hiciste nada.");
    }

    // Verificamos si el villano murió después de tu ataque
    if (vidaVillano <= 0)
    {
        break; // Sale del bucle inmediatamente
    }

    // --- TURNO DEL VILLANO ---
    Console.WriteLine("\nEl villano contraataca...");
    vidaHeroe -= ataqueVillano;
    Console.WriteLine($"¡El villano te quita {ataqueVillano} de vida!");
    
    // Recuperación pasiva de maná cada turno para que no te quedes seco
    manaHeroe += 5;
}

// 3. RESULTADO FINAL
Console.WriteLine("\n--- EL COMBATE HA TERMINADO ---");
if (vidaHeroe > 0)
{
    Console.WriteLine("¡Victoria! El villano ha caído.");
}
else
{
    Console.WriteLine("Has sido derrotado... el mundo está perdido.");
}