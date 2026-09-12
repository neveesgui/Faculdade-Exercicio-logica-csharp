//Um evento permite a entrada de pessoas que atendam a pelo menos uma das condições:

//Possuem 18 anos ou mais;
//Estão acompanhadas por um responsável.

//Entretanto, a entrada só será autorizada se a pessoa também possuir ingresso válido.

//Crie um algoritmo que receba:

//Idade;
//Se está acompanhada;
//Se possui ingresso válido.

//Ao final, informe se a entrada foi autorizada ou negada e apresente o motivo.

Console.WriteLine("============================================");
Console.WriteLine("                 CASA RUFFUS                ");
Console.WriteLine("============================================");
Console.Write("Informe sua idade: ");
int idade = int.Parse(Console.ReadLine());
Console.Write("Voce está acompanhado? ");
string acompanhado = Console.ReadLine();
Console.Write("Possui ingresso? ");
string ingresso = Console.ReadLine();
if ((idade >= 18 || (idade < 18 && acompanhado == "sim")) && ingresso == "sim")
{
    Console.WriteLine("Entrada Liberada!");
}
else if (idade < 18 && acompanhado == "nao")
{
    Console.WriteLine("Acesso Negado! Voce é menor de idade e não está com seu Responsavel.");
}
else if (ingresso == "nao")
{
    Console.WriteLine("Acesso Negado! Seu ingresso não é valido.");
}
