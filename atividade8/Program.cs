Console.Write("Digite um número: ");
int numero = int.Parse(Console.ReadLine());

Console.WriteLine($"---- TABUADA DE {numero} ----");

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{numero} * {i} = {numero * i}");
}