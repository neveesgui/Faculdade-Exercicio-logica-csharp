Console.WriteLine("==============================");
Console.WriteLine("CALCULADOR DE MEDIA ARITMÉTICA");
Console.WriteLine("==============================");
Console.Write("Digite a nota 1: ");
double nota1 = double.Parse(Console.ReadLine());
Console.Write("Digite a nota 2: ");
double nota2 = double.Parse(Console.ReadLine());
double media = (nota1 + nota2) / 2;

Console.WriteLine("==============================");
Console.WriteLine($"A media do aluno foi: {media}");
Console.WriteLine("==============================");

if (media >= 7)
{
    Console.WriteLine("Aluno Aprovado");
}
else if (media >= 4)
{
    Console.WriteLine("Aluno em Recuperação");
}
else
{
    Console.WriteLine("Aluno Reprovado");
}
