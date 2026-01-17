BucleJuego() ;
void BucleJuego()
{
    int vidaJugador = 30 ;
    int vidaEnemigo = 30 ;
    int ataqueJugador = 10 ;
    int ataqueEnemigo = 10 ;
    int accion = 0 ;
    while (vidaJugador > 0 && vidaEnemigo > 0)
    {
        Console.WriteLine("Es tu turno!\n1-Atacar");
        accion = int.Parse(Console.ReadLine()) ;
        
           if (accion == 1)
           {
            vidaEnemigo = vidaEnemigo - ataqueJugador ;
             Console.WriteLine($"Daño realizado!\n vida actual del enemigo:    {vidaEnemigo}") ;
           }
           if (vidaEnemigo > 0)
            {
             vidaJugador = vidaJugador - ataqueEnemigo ;
             Console.WriteLine ($"El enemigo ataca!, recibes: {ataqueEnemigo} de dmg.\n----Tu vida actual: {vidaJugador}") ;
            }
            
    }      
     if (vidaEnemigo <= 0)
            {
            Console.WriteLine("Felicidades! derrotaste al enemigo") ;
            }
              else if (vidaJugador <= 0)
            {
            Console.WriteLine("Fuiste derrotado") ;
            }
             
} 