//Uma lanchonete trabalha com os seguintes produtos:

//Código	Produto			Preço
//1		Hambúrguer		R$ 18,00
//2		Pizza individual	R$ 25,00
//3		Cachorro-quente	R$ 15,00
//4		Refrigerante		R$ 7,00

//Crie um algoritmo que receba o código do produto, a quantidade e a distância da entrega.

//O frete será calculado da seguinte forma:

//Até 3 km: R$ 5,00;
//Acima de 3 km e até 8 km: R$ 8,00;
//Acima de 8 km: R$ 12,00;
//Compras acima de R$ 80,00 recebem frete grátis.

//Apresente o produto, subtotal, frete e valor total. Códigos, quantidades e distâncias inválidas devem ser rejeitados.

Console.WriteLine("===============================================================");
Console.WriteLine("                  DELIVERY  LANCHONETE                         ");
Console.WriteLine("===============================================================");
Console.WriteLine("===============================================================");
Console.WriteLine("MENU:\n[1]Burguer\n[2]Pizza individual\n[3]HotDog\n[4]Refrigerante ");
Console.WriteLine("===============================================================");
Console.WriteLine("PREÇOS:\nR$18,00\nR$25,00\nR$15,00\nR$7,00 ");
Console.WriteLine("===============================================================");
Console.WriteLine("FRETE:\n[Até 3 km]R$ 5,00\n[Acima de 3 km e até 8 km]R$ 8,00\n[Acima de 8 km]R$ 12,00\n2Compras acima de R$ 80,00 recebem frete grátis ");
Console.WriteLine("===============================================================");

Console.Write("Informe qual codigo do produto deseja: ");
int codigo = int.Parse(Console.ReadLine());
Console.Write("Quantidade desejada: ");
int quantidade = int.Parse(Console.ReadLine());
Console.Write("Qual a distancia para a entrega em km: ");
double distancia = double.Parse(Console.ReadLine());
double preco = 0.00;
string nomeproduto = "";
if (quantidade < 1)
{
    Console.WriteLine("Qauntidade inválida.");
    return;
}
if (codigo < 1 || codigo > 4)
{
    Console.WriteLine("Codigo inválido.");
    return;
}
if (codigo == 1)
{
    preco = 18.00;
    nomeproduto = "Burguer";
}
else if (codigo == 2)
{
    preco = 25.00;
    nomeproduto = "Pizza individual";
}
else if (codigo == 3)
{
    preco = 15.00;
    nomeproduto = "HotDog";
}
else if (codigo == 4)
{
    preco = 7.00;
    nomeproduto = "Refrigerante";
}
double subtotal = preco * quantidade;
double frete = 0.00;
if (distancia < 0)
{
    Console.WriteLine("Distancia Inválida.");
    return;
}
    if (subtotal > 80.00)
    {
        frete = 0.00;
    }
    else if (distancia <= 3)
    {
        frete = 5.00;
    }
    else if (distancia > 3 && distancia <= 8)
    {
        frete = 8.00;
    }
    else if (distancia > 8)
    {
        frete = 12.00;
    }
double total = subtotal + frete;
Console.WriteLine("===============================================================");
Console.WriteLine($"Produto: {nomeproduto}");
Console.WriteLine($"Subtotal: R${subtotal}");
Console.WriteLine($"Frete: R${frete} ");
Console.WriteLine($"Total: R${total}");
Console.WriteLine("===============================================================");
Console.WriteLine("Obrigado por comprar conosco, volte sempre!");
Console.WriteLine("===============================================================");
