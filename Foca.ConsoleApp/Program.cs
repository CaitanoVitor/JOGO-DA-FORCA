string palavraSecreta = "ABACATE";


char[] letraCorreta = new char[7];

for (int contadorLetras = 0; contadorLetras < 7; contadorLetras++)
{
    letraCorreta[contadorLetras] = '_';
}

int contadorDeErros = 0;

bool jogadorAcertou = false;
bool jogadorPerdeu = false;

while (!jogadorAcertou && !jogadorPerdeu)
{
    Console.Clear();
    Console.WriteLine("---------------------------------------");
    Console.WriteLine("JOGO DA FORCA");
    Console.WriteLine("---------------------------------------");
    Console.WriteLine("Erros cometidos: " + contadorDeErros + " Erros");
    Console.Write("CHUTES: ");

    for (int contadorLetras = 0; contadorLetras < 7; contadorLetras++)
    {
        Console.Write(letraCorreta[contadorLetras]);
    }

    Console.WriteLine("\n---------------------------------------");
    Console.Write("DIGITE UMA LETRA: ");
    char chute = Convert.ToChar(Console.ReadLine());

    bool letraFoiEncontrada = false;

    for (int contadorPalavraCorreta = 0; contadorPalavraCorreta < palavraSecreta.Length; contadorPalavraCorreta++)
    {

        char letraCorretaAtual = palavraSecreta[contadorPalavraCorreta];

        if (chute == letraCorretaAtual)
        {
            letraCorreta[contadorPalavraCorreta] = chute;
            letraFoiEncontrada = true;
        }
    }

    if (!letraFoiEncontrada)
    {
        contadorDeErros++;
    }

    string letrasCorretasCompletas = string.Join("", letraCorreta);

    if (palavraSecreta == letrasCorretasCompletas)
    {
        jogadorAcertou = true;
        Console.WriteLine($"Parabens, VOCÊ ACERTOU! A Palavra secreta era: {palavraSecreta}");
    }
if (contadorDeErros > 5)
{
    jogadorPerdeu = true;
    Console.WriteLine($"Que Pena, você ERROU! a palavra correta era: {palavraSecreta}");
}

}

Console.WriteLine("Digite ENTER PARA SAIR...");
Console.ReadLine();