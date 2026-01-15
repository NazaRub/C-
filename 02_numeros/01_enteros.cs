WorkWithIntegers();

void WorkWithIntegers()
{
    int a = 18;
    int b = 6;
    int c = a + b;
    Console.WriteLine(c);


    // subtraction
    c = a - b;
    Console.WriteLine(c);

    // multiplication
    c = a * b;
    Console.WriteLine(c);

    // division
    c = a / b;
    Console.WriteLine(c);
}
//WorkWithIntegers();
int a = 5;
int b = 4;
int c = 2;
int d = a + b * c;
Console.WriteLine(d);
// respeta el orden de los operadores matematicos, primero / y * y luego + y - 
d = (a + b) * c;
Console.WriteLine(d);
// podemos forzar un orden con parentesis 

ordenPrecedente () ; 
void ordenPrecedente()
{
    int a = 5 ;
    int b = 4 ;
    int c = 2 ;
    int d = a + b * c ; 
    Console.WriteLine(d) ;
        
    d = (a + b) - 6 * c + (12 * 4) / 3 + 12 ;
    Console.WriteLine(d) ;
    
    int e = 7 ;
    int f = 4 ;
    int g = 3 ;
    int h = (e + f) / g ;
    Console.WriteLine(h) ;
}