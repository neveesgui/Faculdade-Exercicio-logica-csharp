//Uma financeira aprova um empréstimo somente quando todas as condições abaixo forem atendidas:

//O cliente tem 18 anos ou mais;
//Sua renda mensal é igual ou superior a R$ 2.000,00;
//O valor da parcela não ultrapassa 30% da renda;
//O cliente não possui restrição financeira.

//Crie um algoritmo que receba idade, renda, valor da parcela e existência de restrição. 
// Informe se o empréstimo foi aprovado. 
// Caso seja negado, apresente quais condições não foram atendidas.

Console.WriteLine("=================================================");
Console.WriteLine("    GN FINCANCEIRA LTDA - FAÇA SUA SIMULAÇÃO     ");
Console.WriteLine("=================================================");
Console.Write("Insira seu nome: ");
string nome = Console.ReadLine();
Console.Write("Insira sua idade: ");
int idade = int.Parse(Console.ReadLine());
Console.Write("Insira sua renda mensal: ");
double renda = double.Parse(Console.ReadLine());
Console.Write("Insira o valor da parcela: ");
double parcela = double.Parse(Console.ReadLine());
Console.Write("Possui alguma restrição [sim] ou [nao]: ");
string restricao = Console.ReadLine();
if (idade < 18)
{
    Console.WriteLine("Credito Negado, Voce é menor de idade.");
}
else if (parcela > (renda * 0.30))
{
    Console.WriteLine("Credito negado, valor da parcela ultrapassa 30% da sua renda.");
}
else if(renda < 2000)
{
    Console.WriteLine("Credito negado, sua renda é menor que R$2000,00");
}
else if (restricao == "sim" || restricao == "s")
{
    Console.WriteLine("Credito negado, voce possui algum tipo de restrição financeira.");
}
else
{
    Console.WriteLine("EMPRESTIMO APROVADO!");
    Console.WriteLine($"Seja muito Bem Vindo, {nome}!");
    Console.WriteLine($"Renda Mensal: R${renda:F2}");
    Console.WriteLine($"Valor da Parcela: R${parcela:F2}");
    Console.WriteLine("======================================");

}
