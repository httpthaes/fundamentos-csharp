Console.Write("Digite seu nome de usuário: ");
string usuario = Console.ReadLine();

Console.Write("Digite sua senha: ");
string senha = Console.ReadLine();

while (senha != "senha123")
{
    Console.WriteLine("Senha incorreta! Digite novamente.");
    Console.Write("Digite sua senha: ");
    senha = Console.ReadLine();
}

Console.WriteLine($"Olá, {usuario}!");