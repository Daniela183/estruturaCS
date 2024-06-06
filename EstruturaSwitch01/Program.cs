//aula 48
Console.WriteLine("Estrutura Switch-Case\n");
Console.WriteLine("Número de prestações");

int compra = 600;
Console.WriteLine("Valor da Compra R$ 600,00");

Console.Write("Informe o valor das parcelas (1 a 3): ");
var numeroParcelas = Convert.ToInt32(Console.ReadLine());

switch (numeroParcelas)
{
    case 1:
        Console.WriteLine($"Prestação R$ {compra / numeroParcelas}");
        break;
    case 2:
        Console.WriteLine($"Prestação R$ {compra / numeroParcelas}");
        break;
    case 3:
        Console.WriteLine($"Prestação R$ {compra / numeroParcelas}");
        break;
    default:
        Console.WriteLine("Valor inválido, informe 1 2 ou 3");
        break;
}
Console.WriteLine("\nFim do processamento 01\n");

Console.WriteLine("Par ou Ímpar");

Console.Write("Informe o número inteiro: ");
var numero = Convert.ToInt32(Console.ReadLine());

switch (numero % 2)
{
    case 0: Console.WriteLine(numero + " é PAR");
        break;
    case 1:
        Console.WriteLine(numero + " é ÍMPAR");
        break;
}

Console.ReadKey();