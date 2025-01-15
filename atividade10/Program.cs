using System;

class Program
{
    static void Main()
    {
        // Solicita ao usuário para digitar um número
        Console.Write("Digite um número inteiro: ");
        int numero = int.Parse(Console.ReadLine());

        // Verifica se o número é par ou ímpar usando o operador %
        if (numero % 2 == 0)
        {
            Console.WriteLine("O número é par.");
        }
        else
        {
            Console.WriteLine("O número é ímpar.");
        }
    }
}