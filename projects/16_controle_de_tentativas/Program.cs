using System;

class Program {
    static void Main() {

        // Variáveis
        string senha = "123";
        string senhaUser;
        int tentativas = 0;

        // Loop de validação
        do {
            Console.Clear();
            Console.WriteLine("Digite a senha");
            senhaUser = Console.ReadLine();
            tentativas++;
        } while(senha != senhaUser);

        // Resultado
        Console.WriteLine("Senha Correta!, tentativas: {0}", tentativas);
    }
}