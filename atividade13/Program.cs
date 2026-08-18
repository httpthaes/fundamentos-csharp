Console.Write("Digite sua senha: ");
string senha = Console.ReadLine();

if (senha.Length >= 8)
{
    Console.WriteLine("A senha possui 8 ou mais caracteres");
} else
{
    Console.WriteLine("A senha possui menos de 8 caracteres.");
}