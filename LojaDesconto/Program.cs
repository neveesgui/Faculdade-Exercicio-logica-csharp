//Uma loja oferece descontos de acordo com o valor da compra:

//Até R$ 100,00: sem desconto;
//Acima de R$ 100,00 e até R$ 300,00: 5% de desconto;
//Acima de R$ 300,00 e até R$ 500,00: 10% de desconto;
//Acima de R$ 500,00: 15% de desconto.

//Crie um algoritmo que receba o valor da compra e mostre:

//Valor original;
//Percentual de desconto;
//Valor do desconto;
//Valor final da compra.

Console.WriteLine("============");
Console.WriteLine(" CAIXA LOJA ");
Console.WriteLine("============");
Console.Write("Informe o Valor do Produto em R$: ");
double compra = double.Parse(Console.ReadLine());
double desconto5 = compra * (5.0 / 100.0);
double desconto10 = compra * (10.0 / 100.0);
double desconto15 = compra * (15.0 / 100.0);
if (compra > 0 && compra <= 100)
{
    Console.WriteLine($"Valor final da compra: R${compra}");    
    Console.WriteLine($"Desconto não aplicavel!");
}
else if (compra > 100 && compra <= 300)
{
    Console.WriteLine("Voce recebeu 5% de Desconto!");
    Console.WriteLine($"Valor origial: R${compra}");
    Console.WriteLine($"Valor do Desconto: R${desconto5:F2}");
    Console.WriteLine($"Valor final da: R${compra - desconto5}");
}
else if (compra > 300 && compra <= 500)
{
    Console.WriteLine("Voce recebeu 10% de Desconto!");
    Console.WriteLine($"Valor origial: R${compra}");
    Console.WriteLine($"Valor do Desconto: R${desconto10:F2}");
    Console.WriteLine($"Valor final da: R${compra - desconto10}");
}
else if (compra > 500)
{
    Console.WriteLine("Voce recebeu 15% de Desconto!");
    Console.WriteLine($"Valor origial: R${compra}");
    Console.WriteLine($"Valor do Desconto: R${desconto15:F2}");
    Console.WriteLine($"Valor final da: R${compra - desconto15}");
}
else
{
    Console.WriteLine("ERRO: VALOR NÃO ACEITO!");
}
