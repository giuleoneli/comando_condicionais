﻿// Solicita ao usuário que digite um número de 1 a 7
Console.Write("Digite um número de 1 a 7: ");
int numero = int.Parse(Console.ReadLine());

// Verifica qual dia da semana corresponde ao número fornecido
if (numero == 1)
{
    Console.WriteLine("Domingo");
}
else if (numero == 2)
{
    Console.WriteLine("Segunda-feira");
}
else if (numero == 3)
{
    Console.WriteLine("Terça-feira");
}
else if (numero == 4)
{
    Console.WriteLine("Quarta-feira");
}
else if (numero == 5)
{
    Console.WriteLine("Quinta-feira");
}
else if (numero == 6)
{
    Console.WriteLine("Sexta-feira");
}
else if (numero == 7)
{
    Console.WriteLine("Sábado");
}
else
{
    Console.WriteLine("Número inválido. Digite um número de 1 a 7.");
}