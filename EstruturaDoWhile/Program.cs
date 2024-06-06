//aula 53
Console.WriteLine("Do-While\n");

var i = 1;
do
{
    Console.WriteLine($"i= {i}");
    i++;
}
while (i <= 10);
Console.WriteLine("\nFim do processamento 01\n");

Console.WriteLine("Outra abordagem");
var l = 1;
do
{
    Console.WriteLine($"l= {l}");
    l++;
    if (l > 7)
        break;
}
while (l <= 10);
Console.WriteLine("\nFim do processamento 02");

Console.WriteLine("\nDo-While aninhado em forma de Matriz");

int x = 0;
do
{
    int y = 0;
    do
    {
        Console.Write($"({x},{y}) ");
        y++;
    }
    while (y < 5);
    x++;
    Console.WriteLine();
}
while (x < 5);
Console.WriteLine("\nFim do processamento 02");
Console.ReadKey(); 
