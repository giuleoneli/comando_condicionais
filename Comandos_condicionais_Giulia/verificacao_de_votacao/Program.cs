// Solicita ao usuário que digite a idade
Console.Write("Digite sua idade: ");
int idade = int.Parse(Console.ReadLine());

// Verifica se a pessoa pode votar (idade >= 16)
if (idade >= 16)
{
    Console.WriteLine("Você pode votar.");
}
else
{
    Console.WriteLine("Você não pode votar.");
}