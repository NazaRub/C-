Lista();
void Lista()
{
    List<string> super = ["pan","leche","huevo","harina","azucar"] ;
    super.Add("Salsa de tomate") ;
    super.Remove("pan") ;
    foreach (var item in super)
    {
        Console.WriteLine(item);
    }
    Console.WriteLine($"la lista tiene {super.Count}") ;
}