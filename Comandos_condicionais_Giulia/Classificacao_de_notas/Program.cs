// Solicita ao usuário que digite a nota do aluno
Console.Write("Digite a nota do aluno: ");
double nota = double.Parse(Console.ReadLine());

// Classifica a nota em categorias
if (nota >= 9)
{
    Console.WriteLine("Excelente");
}
else if (nota >= 7)
{
    Console.WriteLine("Boa");
}
else if (nota >= 5)
{
    Console.WriteLine("Regular");
}
else
{
    Console.WriteLine("Baixa");
}
