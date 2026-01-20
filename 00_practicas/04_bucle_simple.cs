BucleJuego() ;
void BucleJuego()
{
    int vidaJugador = 30 ;
    int vidaEnemigo = 30 ;
    int ataqueJugador = 10 ;
    int ataqueEnemigo = 10 ;
    int accion = 0 ;
    int experiencia =0 ;
    while (vidaJugador > 0 && vidaEnemigo > 0)
    {
        Console.WriteLine("Es tu turno!\n1-Atacar");
        accion = int.Parse(Console.ReadLine()) ;
        
           if (accion == 1)
           {
            vidaEnemigo = vidaEnemigo - ataqueJugador ;
             Console.WriteLine($"Daño realizado!\nVida actual del enemigo:   {vidaEnemigo}\n") ;
           }
           if (vidaEnemigo > 0)
            {
             vidaJugador = vidaJugador - ataqueEnemigo ;
             Console.WriteLine ($"El enemigo ataca! DMG recibido: {ataqueEnemigo}\n----Tu vida actual: {vidaJugador}\n") ;
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
