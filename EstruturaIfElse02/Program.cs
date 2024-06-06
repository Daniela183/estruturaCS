//aula 46
Console.WriteLine("Instrução if-else\n");
Console.WriteLine("---Nota de aluno---");
Console.Write("Informe a nota do aluno: ");
var nota = Convert.ToInt32(Console.ReadLine());

if (nota > 5)
{
    Console.WriteLine("Aluno Aprovado");
}
else
{
    Console.WriteLine("Aluno Reprovado");
}
Console.WriteLine("\nFim do processamento 01");

Console.WriteLine("\n---Comparação---");
Console.Write("Informe o valor de x: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Informe o valor de y: ");
int y = Convert.ToInt32(Console.ReadLine());

if ( x > y)
{
    Console.WriteLine("x é maior que y");
}
else
{
    if (x < y)
    {
        Console.WriteLine("x é menor que y");
    }
    if (x == y)
    {
        Console.WriteLine("x é igual que y");
    }
}
Console.WriteLine("\nFim do processamento 02");
Console.ReadKey();