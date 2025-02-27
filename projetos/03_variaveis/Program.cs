using System;

class Program {
    static void Main() {

        // Declaração de variáveis
        byte n1 = 10; 
        char letra = 'c';
        float valor = 5.3f;
        string nome = "Alan";
        int num1 = 10, num2 = 2, res;

        Console.Clear();

        res = num1 * num2;

        var aux = nome;

        Console.WriteLine("Valor da variável: " + aux + "...");
        Console.WriteLine("A multiplicação de " + num1 + " com " + num2 + " é igual a: " + res);
        Console.WriteLine(n1);
        Console.WriteLine(letra);
        Console.WriteLine(valor);

    }
}