using System;
using System.Collections.Generic;
using System.Threading;

class Program {
    static void Main() {
        Console.Clear();
        Console.WriteLine("=========");
        LinkedList <string> transp = new LinkedList<string>();

        transp.AddFirst("Carro"); // AddFirst: Adiciona no início da lista
        transp.AddFirst("Avião");
        transp.AddFirst("Navio");
        transp.AddFirst("Motocicleta");

        transp.AddLast("Bicicleta"); // AddLast: Adiciona no fim da lista

        LinkedListNode <string> no;
        no = transp.FindLast("Navio"); // Busca o último nó da lista que contém o valor especificado.
        transp.AddAfter(no, "Patinete"); // AddAfter: Adiciona após
        no = transp.FindLast("Carro");
        transp.AddBefore(no, "Patins"); // AddBefore: Adiciona antes

        // transp.Clear();

        if(transp.Find("Carro") == null) {
            Console.WriteLine("Elemento não encontrado");
        } else {
             Console.WriteLine("Elemento encontrado");
        }

        Console.WriteLine("----");

        transp.Remove("Navio");
        transp.RemoveFirst(); // Remove o primeiro elemento
        transp.RemoveLast(); // Remove o último elemento

        foreach(string t in transp) {
            Console.WriteLine("Transporte: {0}", t);
        }
        
        Console.WriteLine("=========");
        Console.WriteLine("Limpando a tela em 3... 2... 1... ✨");
        Thread.Sleep(3000);
        Console.Clear();
    }
}