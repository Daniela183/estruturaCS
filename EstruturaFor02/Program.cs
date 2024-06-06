//aula 55
Console.WriteLine("Instrução For 02\n");
Console.WriteLine("Loop For");

for (int i = 0, l = 0; i + l <= 20; i++, l++)
{
    Console.WriteLine($"i= {i} e l= {l}");
}

Console.WriteLine("\nFim do processamento 01\n");

Console.WriteLine("Loop for seções opcionais");

int a = 1;
for (; a <= 10;)
{
    Console.WriteLine($"a= {a}");
    a++;
}
Console.WriteLine("\nFim do processamento 02\n");

Console.WriteLine("Loop for aninhado");

for (int x = 0; x < 5; x++)
{
    for (int y = 0; y < 5; y++)
    {
        Console.Write($"({x},{y}) ");
    }
    Console.WriteLine();
}

Console.WriteLine("\nFim do processamento 03\n");

Console.WriteLine("Loop infinito");
int j = 1;
for (; ; )
{
    Console.WriteLine($"j = {j}");
    j++;
}
Console.WriteLine("\nFim do processamento 04\n");
Console.ReadKey();