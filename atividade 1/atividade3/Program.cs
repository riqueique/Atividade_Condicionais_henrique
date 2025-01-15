using System;

class Program
{
    static void Main()
    {
        // Solicita ao usuário que insira um número
        Console.Write("Digite um número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        // Verifica se o número está dentro do intervalo de 1 a 100
        if (numero >= 1 && numero <= 100)
        {
            Console.WriteLine("O número está entre 1 e 100.");
        }
        else
        {
            Console.WriteLine("O número não está entre 1 e 100.");
        }
    }
}
