int[] numeros = new int[10];

for (int i = 0; i < 10; i++)
{
    Console.Write($"Digite um número: ");
    int numero = Convert.ToInt32(Console.ReadLine());

    numeros[numeros.Length - 1 - i] = numero;
}

foreach (var numero in numeros)
{
    Console.WriteLine($"{numero}");
}