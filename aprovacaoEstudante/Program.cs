//Crie um algoritmo que receba duas notas e a quantidade de faltas de um estudante. Calcule sua média e apresente sua situação:

//“Aprovado”: média maior ou igual a 7 e até 15 faltas;
//“Recuperação”: média entre 5 e 6,9 e até 15 faltas;
//“Reprovado por nota”: média menor que 5;
//“Reprovado por faltas”: mais de 15 faltas.

//As notas devem estar entre 0 e 10.

Console.WriteLine("===================================================================================");
Console.WriteLine("CADASTRE AS DUAS NOTAS DO ALUNO, O QUADRO DE FALTAS E DESCUBRA A SITUAÇÃO DO ALUNO");
Console.WriteLine("===================================================================================");
Console.Write("Digite a nota 1: ");
double nota1 = double.Parse(Console.ReadLine());
Console.Write("Digite a nota 2: ");
double nota2 = double.Parse(Console.ReadLine());
Console.Write("Quantas faltas o Aluno teve: ");
int faltas = int.Parse(Console.ReadLine());
double media = (nota1 + nota2) / 2;

Console.WriteLine("==============================");
Console.WriteLine($"A media do aluno foi: {media}");
Console.WriteLine("==============================");
Console.WriteLine("==============================");
Console.WriteLine($"O aluno teve: {faltas} faltas");
Console.WriteLine("==============================");

if (media >= 7 && faltas <= 15)
{
    Console.WriteLine("Aluno Aprovado!");
}
else if ((media > 4 || media < 7 ) && faltas <= 15)
{
    Console.WriteLine("Aluno em Recuperação!");
}
else if (media < 5 || faltas > 15)
{
    Console.WriteLine("Aluno Reprovado!");
}
else if (media < 0)
{
    Console.WriteLine("ERRO: Nota invalida!");
}
