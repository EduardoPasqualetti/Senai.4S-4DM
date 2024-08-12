// Console.WriteLine("Informe a nota do aluno:");
// double note = double.Parse(Console.ReadLine()!);

// while (note > 10 || nota < 0)
// {
//     Console.WriteLine("Informe um numero de 1 a 10 apenas");
//     note = double.Parse(Console.ReadLine()!);
// }

// if (note >= 6)
// {
//     Console.WriteLine("O aluno esta aprovado");
// }
// else if (note <= 5 && note >= 4)
// {
//     Console.WriteLine("O aluno esta de recuperacao");
// }
// else
// {
//     Console.WriteLine(" O aluno reprovou");
// }






// Console.WriteLine("Informe um numero para saber sua tabuada");
// int number = int.Parse(Console.ReadLine()!);

// for (int i = 1; i < 11; i++)
// {
//     Console.WriteLine($"{number} x {i} = {number * i}");
// }






// int count = 1;
// int sumValue = 0;

// while (count <= 100)
// {
    
//     if (count%2 == 0)
//     {
//         sumValue += count;
//     }
//     count++;
// }
// Console.WriteLine(sumValue);






// Random random = new Random();
// int randomNumber = random.Next(1,10);
// int userAttempt; 
// int attemptQuantity = 0;

// Console.WriteLine("Tente adivinhar o numero de 1 a 10");

// do
// {
//     userAttempt = int.Parse(Console.ReadLine()!);

//     if (userAttempt > randomNumber)
//     {
//         Console.WriteLine("Errou! O numero é menor");
//     } else if (userAttempt < randomNumber)
//     {
//         Console.WriteLine("Errou! O numero é maior");
//     } 
//     else {
//         Console.WriteLine($"Voce acertou em {attemptQuantity + 1} tentativas! Parabens");
//     }
//     attemptQuantity++;
// } while (userAttempt != randomNumber);




