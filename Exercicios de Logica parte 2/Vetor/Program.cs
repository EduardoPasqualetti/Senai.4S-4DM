

string[] nomes = new string[5];

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Informe o nome do {i + 1}º usuario:");
    nomes[i] = Console.ReadLine()!;
}
Array.Sort(nomes);
Console.WriteLine("Os nomes cadastrados foram:");

foreach (var nome in nomes)
{
    Console.WriteLine($"- {nome}");
}