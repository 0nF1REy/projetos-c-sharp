using System;
using System.Collections.Generic;
using System.Threading;

class Program {
    static void Main() {

        Console.Clear();
        Console.WriteLine("=========");

        // Fila de monstros na dungeon
        Queue<string> monstros = new Queue<string>();

        monstros.Enqueue("Dragon"); // Adiciona na fila
        monstros.Enqueue("Troll");
        monstros.Enqueue("Minotaur");
        monstros.Enqueue("Demon");

        string monstroProcurado = "Vampire";
        if(monstros.Contains(monstroProcurado)) {
            Console.WriteLine("Monstro " + monstroProcurado + " encontrado na fila da dungeon");
        } else {
            Console.WriteLine("Monstro " + monstroProcurado + " não está na fila da dungeon");
        }

        // monstros.Clear();
        Console.WriteLine("----");
        Console.WriteLine("Primeiro monstro na fila: " + monstros.Dequeue());
        Console.WriteLine("----");
        Console.WriteLine("Próximo monstro da fila: " + monstros.Peek());
        Console.WriteLine("----");

        foreach(string monstro in monstros) {
            Console.WriteLine("Monstro: " + monstro);
        }

        Console.WriteLine("----");
        Console.WriteLine("Tamanho da fila da dungeon: " + monstros.Count);
        Console.WriteLine("----");

        // Console.WriteLine(monstros[2]);

        while(monstros.Count > 0) {
            Console.WriteLine(monstros.Dequeue() + " derrotado!");
        }

        Console.WriteLine("----");
        Console.WriteLine("Tamanho da fila da dungeon: " + monstros.Count);
        
        Console.WriteLine("=========");
        Console.WriteLine("Limpando a tela em 3... 2... 1... ✨");
        Thread.Sleep(3000);
        Console.Clear();
    }
}
