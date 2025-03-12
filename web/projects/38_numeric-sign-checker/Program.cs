using System;

class Program
{
    static void Main(string[] args)
    {
        // Variáveis
        int num;

        // Entrada de dados
        Console.WriteLine("==========================");
        Console.WriteLine("Forneça um número inteiro: ");
        num = Convert.ToInt16(Console.ReadLine()); // Converte de forma explícita string para int
        Console.WriteLine("- - - - - - - -");

        // Testa se o número é maior ou igual a 0
        if (num >= 0)
        {
            Console.WriteLine("Número Positivo!");
        }
        else
        {
            Console.WriteLine("Número Negativo!");
        }

        Console.WriteLine("==========================");
        Console.ReadKey();
    }
}
