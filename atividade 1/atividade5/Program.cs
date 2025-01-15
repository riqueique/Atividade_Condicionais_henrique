using System;

class Program
{
    static void Main()
    {
        // Solicita a nota do aluno
        Console.Write("Digite a nota do aluno: ");
        double nota = Convert.ToDouble(Console.ReadLine());

        // Classifica a nota de acordo com os intervalos fornecidos
        if (nota >= 9)
        {
            Console.WriteLine("EXCELENTE");
        }
        else if (nota >= 7)
        {
            Console.WriteLine("ESTA BOA");
        }
        else if (nota >= 5)
        {
            Console.WriteLine("ESTA REGULAR");
        }
        else
        {
            Console.WriteLine("MUITO BAIXA");
        }
    }
}
