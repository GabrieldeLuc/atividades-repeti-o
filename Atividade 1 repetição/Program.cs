

int nota; 

Console.WriteLine($"Bem vindo ao Sistema, informe a nota, sendo ela um número de zero a dez: ");
 while (!int.TryParse (Console.ReadLine()!, out nota ) || nota > 10)

 {
    Console.WriteLine($"Nota Invalida, Digite Novamente: ");
    
 }

Console.WriteLine($"Nota Validada !");






 



