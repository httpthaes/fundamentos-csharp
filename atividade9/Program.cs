int soma = 0;

for (int i = 1; i <= 100; i++)
{
    bool par = i % 2 == 0;

    if (par)
    {
        soma += i;
    }
}

Console.Write($"Soma dos números pares: {soma}");