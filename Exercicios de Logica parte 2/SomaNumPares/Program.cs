
int[] numbers = new int[] { 2,9,18,40,53,60,61,76,87,98};
int sumNumbers = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    {
        sumNumbers = numbers[i] + sumNumbers;
    }
}
Console.WriteLine($"A soma dos numeros pares é: {sumNumbers}");