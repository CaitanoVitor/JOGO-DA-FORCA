string palavraAleatoria = "ABACATE";


char[] letrasCorretas = new char[7];

for (int contadorDeLetras = 0; contadorDeLetras < 7; contadorDeLetras++)
{
    letrasCorretas[contadorDeLetras] = '_';
    Console.Write(letrasCorretas[contadorDeLetras]);
}
Console.ReadLine();

bool jogadorAcertou = false;

while (!jogadorAcertou)
{
    Console.Clear();
    Console.WriteLine("Digite uma Letra: ");
    char letra = Convert.ToChar(Console.ReadLine());

    Console.WriteLine(letra);
    Console.ReadLine();
}