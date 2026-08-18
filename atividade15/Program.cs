double[] notas = new double[8];
double soma = 0;

for (int i = 0; i < 8; i++)
{
    Console.Write($"Digite a nota {i + 1}: ");
    double nota = Convert.ToDouble(Console.ReadLine());

    notas[i] = nota;
}

foreach (var nota in notas)
{
    soma += nota;
}

double media = soma / 8;
Console.WriteLine($"Soma: {soma:0.#}");
Console.WriteLine($"Média: {media:0.#}");