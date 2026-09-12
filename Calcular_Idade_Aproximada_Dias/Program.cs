Console.WriteLine("=====================================================");
Console.WriteLine("!DESCUBRA QUANTOS DIAS VOCÊ JÁ VIVEU APROXIMADAMENTE!");
Console.WriteLine("=====================================================");
Console.Write("Digite sua idade: ");
int idade = int.Parse(Console.ReadLine());
int dias = (idade * 365) + (idade / 4);
Console.WriteLine("Você viveu aproximadamente " + dias + " dias.");
