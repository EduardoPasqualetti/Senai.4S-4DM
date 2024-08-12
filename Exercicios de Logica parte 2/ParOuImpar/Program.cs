
Console.WriteLine("Bem vindo ao programa, informe um número inteiro:");
int userNumber = int.Parse(Console.ReadLine()!);

if (userNumber%2 == 0)
{
    Console.WriteLine($"o número {userNumber} é par!");
} else{
    Console.WriteLine($"o número {userNumber} é impar");
}