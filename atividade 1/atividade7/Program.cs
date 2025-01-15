using System;

class Program
{
    static void Main()
    {
        // Solicita a idade da pessoa
        Console.Write("Digite sua idade: ");
        int idade = Convert.ToInt32(Console.ReadLine());

        // Verifica se a pessoa pode votar (idade >= 16)
        if (idade >= 16)
        {
            Console.WriteLine("Você pode votar.");
        }
        else
        {
            Console.WriteLine("Você não pode votar.");
        }
    }
}

