
/*for (int row = 1; row < 11; row++)
{
    Console.WriteLine($"The row is {row}");
}for (char column = 'a'; column < 'k'; column++)
{
    Console.WriteLine($"The column is {column}");
    }*/

for (int row = 1; row < 11; row++)
{
    for (char column = 'a'; column < 'k'; column++)
    {
        Console.WriteLine($"The cell is ({row}, {column})");
    }
}
