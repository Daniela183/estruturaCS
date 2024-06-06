//aula 54
Console.WriteLine("Instrução de repetição For\n");

int resultado, numero;

Console.Write("Informe um número inteiro: ");
numero = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    resultado = numero * i;
    Console.WriteLine(numero + " x " + i + " = " + resultado);
}

Console.WriteLine("\nFim do processamento 01\n");
Console.WriteLine("Forma 02");

int res, num;

Console.Write("Informe um número inteiro: ");
num = Convert.ToInt32(Console.ReadLine());

for (var l = 1; l <= 10; l++)
{
    res = num * l;
    Console.WriteLine($"{num} x {l} = {res}");
}

Console.WriteLine("\nFim do processamento 02\n");

Console.WriteLine("Forma 03");

double resul, numer;
double t;

Console.Write("Informe um número inteiro: ");
numer = Convert.ToInt32(Console.ReadLine());

for (t = 1.01; t <= 10.10; t += 0.1)
{
    resul = numer * t;
    Console.WriteLine($"{numer} x {t} = {resul}");
}

Console.WriteLine("\nFim do processamento 03\n");

Console.WriteLine("Forma 04");

double resu, numr;
double I;

Console.Write("Informe um número inteiro maior que zero: ");
numr = Convert.ToInt32(Console.ReadLine());

if (numr > 0)
{
    for (I = 1; I <= 10; I ++)
    {
        resu = numr * I;
        Console.WriteLine($"{numr} x {I} = {resu}");
    }
}
else
{
    Console.WriteLine("Número inválido");
}

Console.WriteLine("\nFim do processamento 04\n");

Console.WriteLine("Forma 05 do maior para o menor");

double resull, numrr;
double a;

Console.Write("Informe um número inteiro maior que zero: ");
numrr = Convert.ToInt32(Console.ReadLine());

if (numrr > 0)
{
    for (a = 10; a > 0; a--)
    {
        resull = numrr * a;
        Console.WriteLine($"{numrr} x {a} = {resull}");
    }
}
else
{
    Console.WriteLine("Número inválido");
}

Console.WriteLine("\nFim do processamento 05\n");
Console.WriteLine("Forma 06 incremento de 2 em 2");

double ressul, nummr;
double b;

Console.Write("Informe um número inteiro maior que zero: ");
nummr = Convert.ToInt32(Console.ReadLine());

if (nummr > 0)
{
    for (b = 1; b <= 20; b+=2)
    {
        ressul = nummr * b;
        Console.WriteLine($"{nummr} x {b} = {ressul}");
    }
}
else
{
    Console.WriteLine("Número inválido");
}

Console.WriteLine("\nFim do processamento 06\n");

Console.ReadKey();
