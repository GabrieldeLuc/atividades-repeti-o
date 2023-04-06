Console.WriteLine($"Informe a tabuada que você deseja saber: ");
int tabuada = int.Parse (Console.ReadLine()!);

for (var i = 1; i <= 10 ; i++)
{
    Console.WriteLine($" o resultado é {tabuada} x {i} = {tabuada * i}");
    
}
