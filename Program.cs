string nome;
string sobrenome;

Console.Write("Digite o primeiro nome: ");
nome = Console.ReadLine()!;

Console.Write("Digite o sobrenome: ");
sobrenome = Console.ReadLine()!;

Console.WriteLine($"nome completo: {nome} {sobrenome}"); 
Console.WriteLine($"nome de catálogo: {sobrenome.ToUpper()}, {nome}");