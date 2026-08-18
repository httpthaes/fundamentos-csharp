int[] notas = { 100, 50, 20, 10, 5, 2 };

Console.Write("Digite um valor para saque: ");
int valor = Convert.ToInt32(Console.ReadLine());


foreach (var nota in notas)
{
    int quantidadeDeNotas = valor / nota;
    valor = valor % nota;

    if (quantidadeDeNotas > 0)
    {
        string textoNota = quantidadeDeNotas == 1 ? "nota" : "notas";
        Console.WriteLine($"{quantidadeDeNotas} {textoNota} de {nota}.");
    }
}

if (valor == 1)
{
    Console.WriteLine("Sobra 1 real.");
}