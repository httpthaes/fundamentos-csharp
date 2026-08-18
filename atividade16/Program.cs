using System.ComponentModel.Design;

List<int> pares = new List<int>();
int contagem = 0;

for (int i = 0; i < 20; i++)
{
    Console.Write($"{i + 1} - Digite um número: ");
    int numero = Convert.ToInt32(Console.ReadLine());

    bool par = numero % 2 == 0;

    if (pares.Contains(numero))
    {
        pares.Remove(numero);
    } else if (par)
    {
        pares.Add(numero);
        contagem++;
    } 
}

Console.WriteLine($"Pares:");

foreach (var par in pares)
{
    Console.WriteLine($"{par}");
}

Console.WriteLine($"Quantidade de pares: {contagem}");