//Um estacionamento utiliza as seguintes regras:

//Primeira hora: R$ 8,00;
//Cada hora adicional: R$ 5,00;
//Aos sábados e domingos, há um acréscimo de 20%;
//Clientes conveniados recebem 15% de desconto;
//O desconto não pode ser acumulado com estacionamento gratuito;
//Permanências de até 15 minutos são gratuitas. OK

//Crie um algoritmo que receba o tempo de permanência, o dia da semana e se o cliente é conveniado. Calcule e apresente:

//Valor básico;
//Acréscimo, quando houver;
//Desconto, quando houver;
//Valor final;
//Uma mensagem explicando as regras aplicadas.

Console.WriteLine("===============================================================");
Console.WriteLine("                  ESTACIONAMENTO                                ");
Console.WriteLine("===============================================================");
Console.WriteLine("===============================================================");
Console.WriteLine("REGRAS:\nPrimeira hora:R$ 8,00\nCada hora adicional:R$ 5,00\nAos sábados e domingos, há um acréscimo de 20%\nClientes conveniados recebem 15% de desconto\nO desconto não pode ser acumulado com estacionamento gratuito\nPermanências de até 15 minutos são gratuitas.");
Console.WriteLine("===============================================================");
Console.Write("Informe o tempo de permanência em minutos: ");
double tempo = double.Parse(Console.ReadLine()!);
Console.Write("Informe o dia da semana (ex: segunda, terça, quarta, quinta, sexta, sabado, domingo): ");
string dia = Console.ReadLine()!;
Console.Write("Informe se o cliente é conveniado (true/false): ");
bool convenio = bool.Parse(Console.ReadLine()!);
double valorbasico;
double acrescimo = 0.00;
double desconto = 0.00;
double valorfinal;
if (tempo <= 0)
{
    Console.WriteLine("Tempo inválido.");
    return;
}
else if (tempo <= 15)
{
    Console.WriteLine("Permanência gratuita.");
    return;
}
else if (tempo > 15 && tempo <= 60)
{
    valorbasico = 8.00;
    if (dia == "sabado" || dia == "domingo")
    {
        acrescimo = valorbasico * 0.20;
    }
    if (convenio)
    {
        desconto = (valorbasico + acrescimo) * 0.15;
    }
    valorfinal = valorbasico + acrescimo - desconto;
    Console.WriteLine($"Valor básico: R$ {valorbasico:F2}");
    Console.WriteLine($"Acréscimo: R$ {acrescimo:F2}");
    Console.WriteLine($"Desconto: R$ {desconto:F2}");
    Console.WriteLine($"Valor final: R$ {valorfinal:F2}");
    Console.WriteLine("Regras aplicadas: Nenhum acréscimo ou desconto aplicado.");
}
else if (tempo > 60)
{
    valorbasico = 8.00 + ((tempo - 60.00) / 60.00) * 5.00;
    if (dia == "sabado" || dia == "domingo")
    {
        acrescimo = valorbasico * 0.20;
    }
    if (convenio)
    {
        desconto = (valorbasico + acrescimo) * 0.15;
    }
    valorfinal = valorbasico + acrescimo - desconto;
    Console.WriteLine("===============================================================");
    Console.WriteLine($"Valor básico: R$ {valorbasico:F2}");
    Console.WriteLine($"Acréscimo: R$ {acrescimo:F2}");
    Console.WriteLine($"Desconto: R$ {desconto:F2}");
    Console.WriteLine($"Valor final: R$ {valorfinal:F2}");
    Console.WriteLine("Regras aplicadas: Acréscimo e desconto aplicados.");
    Console.WriteLine("===============================================================");
}
