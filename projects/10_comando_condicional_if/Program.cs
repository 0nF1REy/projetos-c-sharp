using System;

class Program
{
    static void Main()
    {
        // Declaração de variáveis
        int n1, n2, n3, n4, res;
        res = n1 = n2 = n3 = n4 = 0;
        string resultado;

        // string resultado = "Reprovado!";

        Console.Write("Digite a nota 1: ");
        n1 = int.Parse(Console.ReadLine());

        Console.Write("Digite a nota 2: ");
        n2 = int.Parse(Console.ReadLine());

        Console.Write("Digite a nota 3: ");
        n3 = int.Parse(Console.ReadLine());

        Console.Write("Digite a nota 4: ");
        n4 = int.Parse(Console.ReadLine());

        // if((n1 + n2 + n3 + n4) >= 60) {
        //     resultado = "Aprovado!";
        // }        

        res = n1 + n2 + n3 + n4;

        if (res >= 60) {
            if(res >= 89) {
                if( res >= 99) {
                     resultado = "Aprovado com super louvor!";
                } else {
                     resultado = "Aprovado com louvor!";
                }
            } else {
                  resultado = "Aprovado!";
            }
        } else {
            if(res >= 40) {
                resultado = "Recuperação!";
            } else {
                resultado = "Reprovado!";
            }
        }
        
        Console.WriteLine("Nota: {0} - Resultado: {1}", res, resultado);
    }
}