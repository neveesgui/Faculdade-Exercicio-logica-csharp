//Crie um algoritmo que receba um número inteiro e informe:

//Se ele é positivo, negativo ou igual a zero;
//Se ele é par ou ímpar.

//Use operadores relacionais, o operador de resto da divisão e estruturas condicionais.

Console.WriteLine("=======================");
Console.WriteLine(" VERIFICAÇAO DE NUMERO ");
Console.WriteLine("=======================");
Console.Write("Digite um numero: ");
int num = int.Parse(Console.ReadLine());
if (num % 2 == 0)
{
    Console.WriteLine("Numero Par");
    if (num > 0)
    {
        Console.WriteLine("Numero Positivo");
    }
    else if (num < 0)
    {
        Console.WriteLine("Numero Negativo");
    }
    else if(num == 0)
    {
        Console.WriteLine("Numero igual a Zero\nNumero Positivo");
    }
}
else
{
    Console.WriteLine("Numero Impar");
    if (num > 0)
    {
        Console.WriteLine("Numero Positivo");
    }   
    else
        {
            Console.WriteLine("Numero Negativo");
        }
    }
    