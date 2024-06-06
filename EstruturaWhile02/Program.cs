//aula 52
Console.WriteLine("Instrução While 02");
Console.WriteLine("\n## Para sair tecle 0 ##");
while (true)
{
    Console.Write("\nInforme um número inteiro: ");
    int numero = Convert.ToInt32(Console.ReadLine());

    if (numero == 0)
    {
        break;
    }
    if (numero%2 == 0)
        Console.WriteLine($"{numero} é PAR");
    else
        Console.WriteLine($"{numero} é ÍMPAR");
}
Console.WriteLine("\nFim do processamento 01");
Console.WriteLine("\nWhile aninhado em forma de Matriz");

int x = 0;
while(x < 5)
{
    int y = 0;
    while(y < 5)
    {
        Console.Write($"({x},{y}) ");
        y++;
    }
    x++;
    Console.WriteLine();
}
Console.WriteLine("\nFim do processamento 02");
Console.ReadKey();
