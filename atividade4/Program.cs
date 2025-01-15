using System;

class Program
{
    static void Main()
    {
        // Solicita a idade da pessoa
        Console.Write("Digite sua idade: ");
        int idade = Convert.ToInt32(Console.ReadLine());

        // Verifica se a pessoa é maior ou menor de idade
        if (idade >= 18)
        {
            Console.WriteLine("Você é maior de idade.");
        }
        else
        {
            Console.WriteLine("Você é menor de idade.");
        }
    }
}
