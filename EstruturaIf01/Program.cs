//aula 45
Console.WriteLine("Instrução if\n");
Console.WriteLine("Forma de resolver 01");
Console.Write("Cliente Especial (S/N): ");
var resposta = Console.ReadLine();

if (resposta == "s")
{
    Console.WriteLine("Desconto de 10% aplicado");
}
Console.WriteLine("Fim do processamento");

Console.WriteLine("\nForma de resolver 02");
Console.Write("Cliente Especial (true/false): ");
var resp = Convert.ToBoolean(Console.ReadLine());

if (resp)
{
    Console.WriteLine("Desconto de 10% aplicado");
}
Console.WriteLine("Fim do processamento");

Console.WriteLine("\nForma 03");
Console.Write("Informe o valor de x: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Informe o valor de y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > y)
{
    Console.WriteLine("x é maior que y");
}
if (x < y)
{
    Console.WriteLine("x é menor que y");
}
if (x == y)
{
    Console.WriteLine("x é igual que y");
}
Console.ReadKey();