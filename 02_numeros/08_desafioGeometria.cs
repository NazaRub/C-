DesafioPintor() ;
void DesafioPintor()
{
double radio = 3.75 ;
double precio = 10.50 ;
double area = Math.PI * Math.Pow(radio, 2) ;
double precioTotal = precio * area ;
if (precioTotal > 500)
    {
        precioTotal = precioTotal - 50 ;
        Console.WriteLine("Felicidades, accedio al descuento de $50!") ; 
    } 
else
    {
        Console.WriteLine("No aplicas para el descuento de 50") ;
    }

Console.WriteLine($"El area a pintar es: {Math.Round(area, 2)}. El precio total es: {Math.Round(precioTotal, 2)}") ;
}
