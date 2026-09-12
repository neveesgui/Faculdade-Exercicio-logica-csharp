Console.WriteLine("===============================");
Console.WriteLine("CAMBIO MOEDAS - REAL PARA DOLAR");
Console.WriteLine("===============================");
Console.Write("Quantos reais você deseja converter para dólares? R$");
double reais = double.Parse(Console.ReadLine());
Console.Write("Qual é a cotação do dólar hoje? U$");
double dolar = double.Parse(Console.ReadLine());
double resultado = reais / dolar;
Console.WriteLine("O valor em dolares é: U$${0:F2}", resultado);
