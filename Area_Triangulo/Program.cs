Console.WriteLine("CALCULADORA DE AREA DE UM TRIANGULO");
Console.Write("Digite a base do triangulo: ");
double Base = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a altura do triangulo: ");
double Altura = double.Parse(Console.ReadLine());
double Area = (Base * Altura / 2);
Console.WriteLine("A area do triangulo é: " + Area);
