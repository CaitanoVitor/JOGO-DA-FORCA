

using System.Security.Cryptography;

string[] palavras = [
    "ABACATE",
    "ABACAXI",
    "ACEROLA",
    "ACAI",
    "ARACA",
    "BACABA",
    "BACURI",
    "BANANA",
    "CAJA",
    "CAJU",
    "CARAMBOLA",
    "CUPUACU",
    "GRAVIOLA",
    "GOIABA",
    "JABUTICABA",
    "JENIPAPO",
    "MACA",
    "MANGABA",
    "MANGA",
    "MARACUJA",
    "MURICI",
    "PEQUI",
    "PITANGA",
    "PITAYA",
    "SAPOTI",
    "TANGERINA",
    "UMBU",
    "UVA",
    "UVAIA"
];

int aleatorio = RandomNumberGenerator.GetInt32(palavras.Length);

string palavraSecreta = palavras[aleatorio];


char[] letraCorreta = new char[palavraSecreta.Length];

for (int contadorLetras = 0; contadorLetras < palavraSecreta.Length; contadorLetras++)
{
    letraCorreta[contadorLetras] = '_';
}

int contadorDeErros = 0;

bool jogadorAcertou = false;
bool jogadorPerdeu = false;

while (true)
{
    Console.Clear();
    Console.WriteLine("---------------------------------------");
    Console.WriteLine("JOGO DA FORCA");
    Console.WriteLine("---------------------------------------");
    Console.WriteLine("Erros cometidos: " + contadorDeErros + " Erros");
    Console.Write("CHUTES: ");

    for (int contadorLetras = 0; contadorLetras < palavraSecreta.Length; contadorLetras++)
    {
        Console.Write(letraCorreta[contadorLetras]);
    }


    Console.WriteLine("\n---------------------------------------");

    if (contadorDeErros == 0)
    {
        Console.WriteLine(@" ___________        ");
        Console.WriteLine(@" |/        |        ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@"_|____              ");
    }
    else if (contadorDeErros == 1)
    {
        Console.WriteLine(@" ___________        ");
        Console.WriteLine(@" |/        |        ");
        Console.WriteLine(@" |         o        ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@"_|____              ");

    }
    else if (contadorDeErros == 2)
    {
        Console.WriteLine(@" ___________        ");
        Console.WriteLine(@" |/        |        ");
        Console.WriteLine(@" |         o        ");
        Console.WriteLine(@" |         |        ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@"_|____              ");

    }
    else if (contadorDeErros == 3)
    {
        Console.WriteLine(@" ___________        ");
        Console.WriteLine(@" |/        |        ");
        Console.WriteLine(@" |         o        ");
        Console.WriteLine(@" |        /|        ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@"_|____              ");

    }

    else if (contadorDeErros == 4)
    {
        Console.WriteLine(@" ___________        ");
        Console.WriteLine(@" |/        |        ");
        Console.WriteLine(@" |         o        ");
        Console.WriteLine(@" |        /|\       ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@"_|____              ");

    }

    else if (contadorDeErros == 5)
    {
        Console.WriteLine(@" ___________        ");
        Console.WriteLine(@" |/        |        ");
        Console.WriteLine(@" |         o        ");
        Console.WriteLine(@" |        /|\       ");
        Console.WriteLine(@" |        / \       ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@"_|____              ");
    }

    else if (contadorDeErros == 6)
    {
        Console.WriteLine(@" ___________        ");
        Console.WriteLine(@" |/        |        ");
        Console.WriteLine(@" |         |        ");
        Console.WriteLine(@" |         o        ");
        Console.WriteLine(@" |        /|\       ");
        Console.WriteLine(@" |        / \       ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@" |                  ");
        Console.WriteLine(@"_|____              ");
    }

    Console.WriteLine("\n--------------------------------------------");

    if (jogadorAcertou)
    {
        Console.WriteLine($"Parabens, VOCÊ ACERTOU! A Palavra secreta era: {palavraSecreta}");
        break;
    }
    else if (jogadorPerdeu)
    {
        Console.WriteLine($"Que Pena, você ERROU! a palavra correta era: {palavraSecreta}");
        break;
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
        jogadorAcertou = true;


    if (contadorDeErros > 5)
        jogadorPerdeu = true;


}

Console.WriteLine("\n--------------------------------------------");
Console.WriteLine("Digite ENTER PARA SAIR...");
Console.ReadLine();