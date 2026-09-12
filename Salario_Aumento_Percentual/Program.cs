Console.WriteLine("===============================");
Console.WriteLine(" AUMENTO SALARIAL - PERCENTUAL ");
Console.WriteLine("===============================");
Console.Write("Qual é o salario atual em R$: ");
double sBase = double.Parse(Console.ReadLine());
Console.Write("Qual é o percentual de aumento %: ");
double aumento = double.Parse(Console.ReadLine());
double sNovo = sBase *(1 + aumento / 100);
Console.WriteLine("O novo salario é: R$ {0:F2}", sNovo);
