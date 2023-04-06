
string senha;


Console.WriteLine($"Bem Vindo ao Sistema,Informe seu nome: ");
string nome = Console.ReadLine()!;

System.Console.WriteLine($"Agora, crie e informe uma Senha: ");
senha = Console.ReadLine()!;

while (senha == nome)
{
    Console.Write($"Sua Senha não pode ser igual ao seu nome, digite novamente: ");
    senha =(Console.ReadLine()!);
    
}

Console.WriteLine($"Informações Validadas !");
