﻿internal class Program
{
    private static void Main(string[] args)
    {
        double num1, num2;

        Console.WriteLine("Digite um valor para o primeiro número:");
        num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite um valor para o segundo número:");
        num2 = Convert.ToDouble(Console.ReadLine());

        if (num1 > 0 && num2 > 0)
            Console.WriteLine("Valores são válidos.");
        else
            Console.WriteLine("Valores inválidos.");

        Console.ReadKey();
    }
}