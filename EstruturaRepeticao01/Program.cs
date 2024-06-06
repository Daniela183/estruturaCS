//aula 50
Console.WriteLine("Estrutura de Repetição com goto/label");

int i = 1;
repetir:
Console.WriteLine($"i= {i}");

i++;

if (i <= 10)
    goto repetir;

Console.WriteLine("\nFim do processamento");

Console.ReadKey();
