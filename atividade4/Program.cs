Console.Write("Digite o valor em reais: R$ ");
double real = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a cotação do dólar: R$ ");
double cotacao = Convert.ToDouble(Console.ReadLine());
double dolar = real / cotacao;

Console.WriteLine($"Valor em dólar: US$ {dolar:F2}");