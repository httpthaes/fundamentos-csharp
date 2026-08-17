Console.WriteLine("------- CALCULADORA -------");

Console.Write("Digite o primeiro número: ");
double numero1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o segundo número: ");
double numero2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Soma: {numero1 + numero2}");
Console.WriteLine($"Subtração: {numero1 - numero2}");
Console.WriteLine($"Multiplicação: {numero1 * numero2}");
Console.WriteLine($"Divisão: {numero1 / numero2}");