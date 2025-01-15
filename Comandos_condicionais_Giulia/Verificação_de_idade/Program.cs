// Solicita ao usuário que digite a idade
Console.Write("Digite sua idade: ");
int idade = int.Parse(Console.ReadLine());

// Verifica se a pessoa é maior de idade ou menor de idade
if (idade >= 18)
{
    Console.WriteLine("Você é maior de idade.");
}
else
{
    Console.WriteLine("Você é menor de idade.");
}