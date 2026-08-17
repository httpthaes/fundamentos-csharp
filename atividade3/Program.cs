Console.Write("Digite a base: ");
double baseRetangulo = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a altura: ");
double alturaRetangulo = Convert.ToDouble(Console.ReadLine());

double area = baseRetangulo * alturaRetangulo;
double perimetro = (2 * baseRetangulo) + (2 * alturaRetangulo);

Console.WriteLine($"Área: {area}");
Console.WriteLine($"Perímetro: {perimetro}");