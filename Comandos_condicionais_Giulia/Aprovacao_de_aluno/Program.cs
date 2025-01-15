// Solicita ao usuário que digite a nota do aluno
Console.Write("Digite a nota do aluno: ");
double nota = double.Parse(Console.ReadLine());

// Verifica se a nota é maior ou igual a 6
if (nota >= 6)
{
    Console.WriteLine("Aluno aprovado.");
}
else
{
    Console.WriteLine("Aluno reprovado.");
}