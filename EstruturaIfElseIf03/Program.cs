//aula 47
Console.WriteLine("Instrução if-else-if\n");
Console.WriteLine("---Instrução aninhada---");
Console.Write("Informe a nota do aluno: ");
var nota = Convert.ToDouble(Console.ReadLine());

if (nota < 5)
{
    Console.WriteLine("Aluno Reprovado");
}
else if (nota >= 5 && nota < 6)
{
    Console.WriteLine("Aluno Em Recuperação");
}
else if(nota >= 6 && nota <= 9)
{
    Console.WriteLine("Aluno Aprovado");
}
else if (nota > 9)
{
    Console.WriteLine("Aluno Aprovado Com Distinção");
}
//Pode ser feito dessa forma
//else
//{
//    Console.WriteLine("Aluno Aprovado Com Distinção");
//}
Console.WriteLine("\nFim do processamento");

Console.ReadKey();
