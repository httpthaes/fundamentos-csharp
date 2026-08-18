int soma = 0;
int numero = 0;

do
{
    Console.Write("Digite um número: ");
    numero = Convert.ToInt32(Console.ReadLine());

    soma += numero;
} while (numero != 0) ;

Console.WriteLine($"Soma dos valores: {soma}");