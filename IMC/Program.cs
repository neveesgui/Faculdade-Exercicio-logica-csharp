Console.WriteLine("===============================================");
Console.WriteLine(" CALCULADORA DE IMC - ÍNDICE DE MASSA CORPORAL ");
Console.WriteLine("===============================================");
Console.Write("Qual o seu Peso em kg: ");
double peso = double.Parse(Console.ReadLine());
Console.Write("Qual a sua Altura em metros: ");
double altura = double.Parse(Console.ReadLine());
double imc = peso / Math.Pow(altura, 2);
Console.WriteLine("Seu IMC é: {0:F2}", imc);
if (imc < 18.5)
{
    Console.WriteLine("Peso abaixo do normal");
}
else if (imc >= 18.5 && imc <25)
{
    Console.WriteLine("Peso Normal");
}
else if (imc >= 25 && imc <30)
{
    Console.WriteLine("Você está com Sobrepeso");
}
else
{
    Console.WriteLine("Você está com Obesidade"); 
}
