

Console.WriteLine("Digite um texto:");
string texto = Console.ReadLine()!.ToLower();

Dictionary<char, int> contagemLetras = new Dictionary<char, int>();

for (char c = 'a'; c <= 'z'; c++)
{
    contagemLetras[c] = 0;
}

foreach (char c in texto)
{
    if (char.IsLetter(c)) 
    {
        contagemLetras[c]++;
    }
}

Console.WriteLine("Contagem de cada letra no texto:");
foreach (var item in contagemLetras)
{
    Console.WriteLine($"{item.Key}: {item.Value}");
}