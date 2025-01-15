// Solicita ao usuário que digite dois números
Console.Write("Digite o primeiro número: ");
double numero1 = double.Parse(Console.ReadLine());

Console.Write("Digite o segundo número: ");
double numero2 = double.Parse(Console.ReadLine());

// Compara os dois números
if (numero1 > numero2)
{
    Console.WriteLine("O primeiro número é maior.");
}
else if (numero1 < numero2)
{
    Console.WriteLine("O segundo número é maior.");
}
else
{
    Console.WriteLine("Os números são iguais.");
}
