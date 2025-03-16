using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        ExibirSeparadorIgual();

        // ======================
        //  Interpolação de String
        // ======================

        // =========
        //  Variáveis
        // =========
        string nome = "Alan";
        string sobrenome = "Ryan";
        string nomeCompleto = $"{nome} {sobrenome}";

        Console.WriteLine("Programa desenvolvido por " + nomeCompleto);

        ExibirSeparadorHifen();

        Console.WriteLine("Por favor, insira o primeiro número: ");
        int numero1 = int.Parse(Console.ReadLine());

        ExibirSeparadorHifen();

        Console.WriteLine("Agora, insira o segundo número: ");
        int numero2 = int.Parse(Console.ReadLine());

        ExibirSeparadorHifen();

        // Math.Max e Math.Min
        Console.WriteLine($"O maior número informado foi: {Math.Max(numero1, numero2)}");
        Console.WriteLine($"E o menor número informado foi: {Math.Min(numero1, numero2)}");

        ExibirSeparadorIgual();
        Console.WriteLine("");
    }
    
    // ===========
    //  Separadores
    // ===========
    static void ExibirSeparadorIgual()
    {
        Console.WriteLine("================");
    }

    static void ExibirSeparadorHifen()
    {
        Console.WriteLine("----------------");
    }
}