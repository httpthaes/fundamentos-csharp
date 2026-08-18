int[] numeros = new int[10];
int maiorNumero = 0;
int posicao = 0;

for (int i = 0; i < 10; i++)
{
    Console.Write("Digite um número: ");
    int numero = Convert.ToInt32(Console.ReadLine());
    numeros[i] = numero;

    if (numero > maiorNumero)
    {
        maiorNumero = numero;
        posicao = i;
    }
}

Console.WriteLine($"Maior valor: {maiorNumero}");
Console.WriteLine($"Posição: {posicao}");