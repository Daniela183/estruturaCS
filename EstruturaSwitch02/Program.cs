//aula 49
Console.WriteLine("Estrutura Switch-Case\n");
Console.WriteLine("Dias e Meses do ano");

Console.Write("Informe o nome do mês: ");
var mes = Console.ReadLine().ToLower();

switch (mes)
{
    case "janeiro":
    case "março":
    case "maio":
    case "julho":
    case "agosto":
    case "outubro":
    case "dezembro":
        Console.WriteLine("Este mês tem 31 dias");
        break;
    case "fevereiro":
        Console.WriteLine("Este mês tem 28 ou 29 dias");
        break;
    default:
        Console.WriteLine("Este mês tem 30 dias");
        break;
}

Console.WriteLine("\n---Instrução switch aninhada---");

int cargo = 0;
int funcao = 0;
Console.Write("Você é Gerente(1) ou Programador(2): ");
cargo = Convert.ToInt32(Console.ReadLine());

if (cargo == 2)
{
    Console.Write("Você é Junior(1) ou Senior(2): ");
    funcao= Convert.ToInt32(Console.ReadLine());
}
switch (cargo)
{
    case 1: Console.WriteLine("Bem Vindo Gerente");
        break;
    case 2: Console.Write("Bem Vindo Programador");
        switch (funcao)
        {
            case 1: Console.Write(" Junior");
                break;
            case 2:
                Console.Write(" Senior");
                break;
            default:
                Console.WriteLine("Funçao desconhecida");
                break;
        }
        break;
    default:
        Console.WriteLine("Não consigo identificar");
        break;
}
Console.ReadKey();
