using System;

class Program {
    static void Main() {

        Console.Clear();
        Console.WriteLine("========================");

        Console.Write("Digite um número inteiro: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite outro número inteiro: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int resultadoSoma = soma(num1, num2);
        Console.WriteLine("A soma de {0} e {1} é: {2}", num1, num2, resultadoSoma);

        Console.Write("\nDigite um texto: ");
        string texto1 = Console.ReadLine() ?? "";  

        Console.Write("Digite outro texto: ");
        string texto2 = Console.ReadLine() ?? "";  

        string resultadoConcatenacao = concatenar(texto1, texto2);
        Console.WriteLine("A concatenação de '{0}' e '{1}' é: '{2}'", texto1, texto2, resultadoConcatenacao);

        Console.WriteLine("========================");
    }

    static int soma(int a, int b) {
        return a + b;
    }

    static string concatenar(string str1, string str2) {
        return str1 + str2;
    }
}
