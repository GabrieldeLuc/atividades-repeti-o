int idademulher = 0; 

int idadehomem = 0;

char sexo; 

float peso; 

int totaldehomens = 0; 

int totaldemulheres = 0; 

float mediaidadeMulher = 0 ; 

float mediaidadehomem = 0;

for (var i = 1; i <= 10; i++)
{
   Console.WriteLine($"Bem vindo ao Sistema, informe o seu sexo, (m) para masculino e (f) para feminino ");
   sexo = char.Parse (Console.ReadLine()!);
   
    if (sexo == 'f')
    {   
    totaldemulheres++;


      }

      else {

        totaldehomens++;
      }

      Console.WriteLine($"informe o peso: ");
     peso = float.Parse (Console.ReadLine()!);
      
    if (sexo == 'f')  {  
 
Console.WriteLine($"informe a idade: ");
idademulher = int.Parse (Console.ReadLine()!);

   }

else {
    Console.WriteLine($"informe a idade:");
    idadehomem = int.Parse (Console.ReadLine()!);
    
    
}

}

mediaidadeMulher = (float)Math.Round(((double)idademulher/totaldemulheres));

mediaidadehomem = (float)Math.Round(((double)idadehomem/totaldehomens));

Console.WriteLine($"o total de mulheres é {totaldemulheres}");
Console.WriteLine($"o total de homens é {totaldehomens}");
Console.WriteLine($"a media da idade das mulheres é {mediaidadeMulher}");
Console.WriteLine($"a media da idade dos homens é {mediaidadehomem}");






