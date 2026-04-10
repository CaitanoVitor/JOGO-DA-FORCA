string palavraSecreta = "ABACATE";


char[] letraCorreta = new char[7];

for (int contadorLetras = 0; contadorLetras < 7; contadorLetras++)
{
    letraCorreta[contadorLetras] = '_';
}

int contadorDeErros = 0;

bool jogadorAcertou = false;

while (!jogadorAcertou)
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

    for (int contadorPalavraCorreta = 0; contadorPalavraCorreta < palavraSecreta.Length; contadorPalavraCorreta++)
    {

        char letraCorretaAtual = palavraSecreta[contadorPalavraCorreta];

        if (chute == letraCorretaAtual)
        {
            letraCorreta[contadorPalavraCorreta] = chute;
        }
    }

    string letrasCorretasCompletas = string.Join("", letraCorreta);

    if (palavraSecreta == letrasCorretasCompletas)
    {
        jogadorAcertou = true;
        Console.WriteLine($"Parabens, VOCÊ ACERTOU! A Palavra secreta era: {palavraSecreta}");
    }

}

Console.ReadLine();