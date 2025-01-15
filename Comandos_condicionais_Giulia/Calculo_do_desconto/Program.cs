// Solicita ao usuário que digite o valor da compra
Console.Write("Digite o valor da compra: ");
double valor = double.Parse(Console.ReadLine());

// Verifica se o valor é maior que 100 e aplica o desconto
if (valor > 100)
{
    double valorComDesconto = valor * 0.9; // Aplica o desconto de 10%
    Console.WriteLine("Valor com desconto: " + valorComDesconto.ToString("F2"));
}
else
{
    Console.WriteLine("Valor original: " + valor.ToString("F2"));
}