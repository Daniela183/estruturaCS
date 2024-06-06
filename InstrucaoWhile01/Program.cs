//aula 51
Console.WriteLine("Instrução While 01");

var i = 1;
while(i <= 10)
{
    Console.WriteLine($"i= {i}");
    i++;
}

Console.WriteLine("\nOutra abordagem");
var l = 10;
while (l > 0)
{
    Console.WriteLine($"l= {l}");
    l--;
}

Console.WriteLine("\nFim do processamento\n");
Console.WriteLine("Tabuada de um número");

int numero;
int contador = 1;

Console.WriteLine("\nDigite um número maior que zero");
numero = Convert.ToInt32(Console.ReadLine());

if (numero > 0)
{
    Console.WriteLine($"Tabuada do {numero} ");
    while(contador < 11)
    {
        Console.WriteLine($"{numero} x {contador} = {numero*contador}");
        contador++;
    }
}
else
{
    Console.WriteLine("\nO número de ser maior que zero");
}


Console.WriteLine("\nFim do processamento");

Console.ReadKey();