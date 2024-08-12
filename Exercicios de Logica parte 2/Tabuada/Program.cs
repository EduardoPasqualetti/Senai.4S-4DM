﻿namespace Tabuada;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe um número para tabuada: ");
        int userNumber = int.Parse(Console.ReadLine()!);

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{userNumber} x {i} = {userNumber * i}");
        }
    }
}