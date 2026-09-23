Console.WriteLine("==== UMBRELLA CORP - VIRUS DETECTION SYSTEM ====");
Console.WriteLine("Initializing...\n");

// 1. Proposição P: Validação física da pulseira
Console.Write("Você possui a pulseira nível 3? (true/false): ");
bool possuiPulseiraNivel3 = bool.Parse(Console.ReadLine() ?? "false");

// 2. Validação da credencial com repetição:
// o laço continua enquanto houver tentativas disponíveis e a senha estiver incorreta.
string senhaSistema = "umbrella1998";
int tentativas = 0;
bool senhaCorreta = false;

while (tentativas < 3 && !senhaCorreta)
{
	tentativas+=1;
	Console.Write($"[Tentativa {tentativas}/3] Digite a senha de acesso: ");
	string senhaDigitada = Console.ReadLine() ?? "";

	senhaCorreta = senhaDigitada == senhaSistema;

	if (!senhaCorreta && tentativas < 3)
	{
		Console.WriteLine("Senha incorreta. Tente novamente.\n");
	}
}

// 3. Tomada de Decisão com a Expressão Lógica (P && Q)
// P = possuiPulseiraNivel3
// Q = senhaCorreta
Console.WriteLine("\n-------------------------------------------");
if (possuiPulseiraNivel3 && senhaCorreta)
{
	Console.WriteLine("ACESSO LIBERADO: Bem-vindo à área do antivírus!");
}
else
{
	Console.WriteLine("ACESSO NEGADO: Protocolo de contenção ativado.");
}
