using System;

class Program
{
    static void Main()
    {
        // Solicita ao usuário que insira dois números
        Console.Write("Digite o primeiro número: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        // Compara os dois números e exibe a mensagem apropriada
        if (numero1 > numero2)
        {
            Console.WriteLine("O primeiro número é maior.");
        }
        else if (numero2 > numero1)
        {
            Console.WriteLine("O segundo número é maior.");
        }
        else
        {
            Console.WriteLine("Os números são iguais.");
        }
    }
}
