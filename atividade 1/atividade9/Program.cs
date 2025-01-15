using System;

class Program
{
    static void Main()
    {
        // Solicita o valor da compra
        
        
        Console.Write("Digite o valor da compra: ");
        double valorCompra = Convert.ToDouble(Console.ReadLine());

        // Verifica se o valor é maior que 100 e aplica o desconto
       
        if (valorCompra > 100)
        {
            double valorDesconto = valorCompra * 0.10; // Calcula 10% de desconto
            double valorFinal = valorCompra - valorDesconto; // Aplica o desconto
            Console.WriteLine("Valor com desconto: " + valorFinal.ToString("F2"));
        }
        else
        {
            Console.WriteLine("Valor original: " + valorCompra.ToString("F2"));
        }
    }
}
