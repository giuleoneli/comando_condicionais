// Solicita ao usuário que digite um número
Console.Write("Digite um número: ");
int numero = int.Parse(Console.ReadLine());

// Verifica se o número está entre 1 e 100
if (numero >= 1 && numero <= 100)
{
    Console.WriteLine("O número está entre 1 e 100.");
}
else
{
    Console.WriteLine("O número não está entre 1 e 100.");
}
