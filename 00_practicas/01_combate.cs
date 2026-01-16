bool llave = true ; 
bool puerta = false; 
int pj = 0 ;
int caminoCorrecto = 1 ;
int path = 0 ;

while ((puerta == false) || (path != caminoCorrecto))

{

Console.WriteLine("Elegi el camino\nIzquierda: 1\nderecha: 2") ;
path = int.Parse(Console.ReadLine()) ;

if ( path == caminoCorrecto) 
{
 pj = path ;
 puerta = true ;
}
if ((puerta == true) && (path == caminoCorrecto))
    {
        Console.WriteLine("Felicidades! abriste la puerta") ;
    }
}

