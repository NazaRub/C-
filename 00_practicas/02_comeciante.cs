int agua = 3 ; 
int dinero = 100 ; 
int distancia = 5 ; 
int distanciaRecorrido = 0 ;
int opcion = 0 ;

 while ((distanciaRecorrido < 5) && (agua > 0))
{
    Console.WriteLine("Que queres hacer?\n1-Avanzar\n2-comprar agua") ;
    opcion = int.Parse(Console.ReadLine()) ;
    if (opcion == 1)
    {
        agua -= 1 ;
        distancia -= 1 ;
        distanciaRecorrido +=  1 ;
    }
    
}