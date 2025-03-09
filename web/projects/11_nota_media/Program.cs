using System;

class Program
{
    static void Main()
    {
        int nota1, nota2, nota3;
        double media;

        nota1 = nota2 = nota3 = 0;
        media = 0.0;

        Console.Write("Digite a primeira nota (0-10): ");
        nota1 = int.Parse(Console.ReadLine());

        Console.Write("Digite a segunda nota (0-10): ");
        nota2 = int.Parse(Console.ReadLine());

        Console.Write("Digite a terceira nota (0-10): ");
        nota3 = int.Parse(Console.ReadLine());

        media = (nota1 + nota2 + nota3) / 3.0;

        Console.WriteLine($"Média final: {media:F2}");
        Console.WriteLine($"Conceito: {ObterConceito(media)}");
    }
    
    static string ObterConceito(double media)
    {
        if (media >= 9) return "MB (Muito Bom)";
        if (media >= 7) return "B (Bom)";
        if (media >= 5) return "R (Regular)";
        return "I (Insatisfatório)";
    }
}
