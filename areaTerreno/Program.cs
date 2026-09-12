//Crie um algoritmo que receba a largura e o comprimento de um terreno retangular. Calcule sua área e apresente uma das classificações:

//Área menor que 100 m²: “Terreno pequeno”;
//Área entre 100 m² e 300 m²: “Terreno médio”;
//Área maior que 300 m²: “Terreno grande”.

//O algoritmo não deve aceitar medidas menores ou iguais a zero.

Console.WriteLine("========================================");
Console.WriteLine(" CALCULADORA AREA DE TERRENO RETANGULAR ");
Console.WriteLine("========================================");
Console.Write("Qual a largura do terreno em m²: ");
double largura = double.Parse(Console.ReadLine());
Console.Write("Qual o comprimento do terreno em m²: ");
double comprimento = double.Parse(Console.ReadLine());
double area = largura * comprimento;
Console.WriteLine($"A area do seu Terreno e: {area:F2}m²");
if (area < 100)
{
    Console.WriteLine("Classificação: Terreno Pequeno");
}   
else if (area >= 100 && area <= 300)
    {
        Console.WriteLine("Classificação: Terreno Medio");
    }  
else if (area <= 0)
{
    Console.WriteLine("ERRO : Valor nao aceito!");
}
else
{
    Console.WriteLine("Classificação: Terreno Grande");
}
