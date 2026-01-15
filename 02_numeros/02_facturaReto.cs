using System.Numerics;

calcularFactura() ;
void calcularFactura()
{
    int remera = 15 ;
    int zapatillas = 60 ;
    int pantalon = 25 ;
    int total = (remera *2) + pantalon + (zapatillas * 2) ;
    int descuento = total * 10 / 100 ;
    Console.WriteLine(total) ;
    Console.WriteLine(total - descuento) ;
    
}