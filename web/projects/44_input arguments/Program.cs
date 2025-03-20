using System;

class Program {
    static void Main(string[] args) {

        Console.Clear();
        Console.WriteLine("=====");

        if(args.Length > 0) {
            Console.WriteLine("Quantidade de argumentos: {0}", args.Length);
            Console.WriteLine("Argumentos passados:");
            for(int i = 0; i < args.Length; i++) {
                Console.WriteLine("Argumento {0}: {1}", i + 1, args[i]);
            }
        } else {
            Console.WriteLine("Não foram passados argumentos");
        }

        Console.WriteLine("=====");
    }
}