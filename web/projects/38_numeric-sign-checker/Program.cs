using System;

class Program
{
    static void Main(string[] args)
    {
        // Variável
        int num;

        // Entrada de dados
        Console.WriteLine("==========================");
        Console.WriteLine("Forneça um número inteiro: ");
        num = Convert.ToInt16(Console.ReadLine()); 
        Console.WriteLine("- - - - - - - -");

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
