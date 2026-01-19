using System.IO.Compression;

int numero = 1 ;
int suma = 0 ;

while (numero <= 20)
{
    if (numero % 3 == 0)
    {
        suma = suma + numero ;
        Console.WriteLine($"\n{numero} Es divisor de 3") ;
    }
    else if (numero % 3 != 0)
    {
        Console.WriteLine($"\n{numero} No es divisor de 3") ;
    }
    numero  ++ ;
}
Console.WriteLine($"El resultado final es: {suma}");