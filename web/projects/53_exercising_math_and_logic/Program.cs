using System;
using System.Threading;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("=========");

        string textoBacana = "Alan Ryan";

        Console.WriteLine("Seja Bem-Vindo! {0} Bacana", textoBacana);

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Digite três números para calcular a média:");
            
            int num1 = Convert.ToInt32(Console.ReadLine());
            
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());

            double media = (num1 + num2 + num3) / 3.0;

            Console.WriteLine($"O resultado da média é: {media}");

            Console.WriteLine(media >= 7 ? "Aprovado, eba!!! 🎉" : "Reprovado!");
        }

        Console.WriteLine("\nDigite um número para calcular seu quadrado:");
        int numQuadrado = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"O quadrado de {numQuadrado} é: {Math.Pow(numQuadrado, 2)}");

        Console.WriteLine("\nDigite um número para verificar se é par ou ímpar:");
        int numParImpar = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(numParImpar % 2 == 0 ? "Par" : "Ímpar");

        Console.WriteLine("\nDigite seu nome:");
        string nomeBacana = Console.ReadLine();
        Console.WriteLine($"Boas-vindas, senhorito {nomeBacana}!");

        Console.WriteLine("\nDigite o lado do quadrado para calcular sua área:");
        int ladoQuadrado = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"A área do quadrado é: {Math.Pow(ladoQuadrado, 2)}");

        Console.WriteLine("\nDigite o lado do quadrado para calcular seu perímetro:");
        int perimetro = Convert.ToInt32(Console.ReadLine()) * 4;
        Console.WriteLine($"O perímetro do quadrado é: {perimetro}");

        Console.WriteLine("=========");
        Console.WriteLine("Obrigado por usar o programa! 🚀");
        Console.WriteLine("Limpando a tela em 3... 2... 1... ✨");
        Thread.Sleep(3000);
        Console.Clear();
    }
}
