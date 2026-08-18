int numeroAleatorio = new Random().Next(1, 101);
int numeroDigitado = -1;

do
{
    Console.Write($"Digite um número: ");
    numeroDigitado = Convert.ToInt32(Console.ReadLine());

    if (numeroDigitado < numeroAleatorio)
    {
        Console.WriteLine($"O número aleatório é maior que {numeroDigitado}");
    }
    else if (numeroDigitado > numeroAleatorio)
    {
        Console.WriteLine($"O número aleatório é menor que {numeroDigitado}");
    }
} while (numeroDigitado != numeroAleatorio);

Console.Write($"Parabéns, você acertou o número {numeroAleatorio}.");