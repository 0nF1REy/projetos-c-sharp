using System;
using System.Collections.Generic;
using System.Threading;

class Program {
    static void Main() {
        Console.Clear();
        Console.WriteLine("=========");

        Dictionary <int, string> veiculos = new Dictionary <int, string>();

        veiculos.Add(10, "Carro");
        veiculos.Add(5, "Avião");
        veiculos.Add(0, "Navio");
        veiculos.Add(20, "Moto");
        veiculos.Add(15, "Patinete");

        // =================
        //  veiculos.Clear();
        // =================
        veiculos.Remove(20);
        
        Console.WriteLine("Tamanho do Dictionary: {0}", veiculos.Count);
    
        Console.WriteLine("----");
        int chave = 20;
       
        if (veiculos.ContainsKey(chave)) { // ContainsKey: Verifica se a chave existe no Dictionary.
            Console.WriteLine("A chave {0} está na coleção!", chave);
        } else {
            Console.WriteLine("A chave {0} não está na coleção!", chave);
        }

        veiculos[15]="Bicicleta"; // Foi mudado o valor da chave 15 para bicicleta.

        Console.WriteLine("----");
        string valor = "Bicicleta";
       
        if (veiculos.ContainsValue(valor)) { // ContainsKey: Verifica se o valor existe no Dictionary.
            Console.WriteLine("O valor {0} está na coleção!", valor);
        } else {
            Console.WriteLine("O valor {0} não está na coleção!", valor);
        }

        Console.WriteLine("----");

        // 01
        Dictionary<int, string>.ValueCollection valores = veiculos.Values;
        foreach(string v in valores) {
            Console.WriteLine(v);
        }

        Console.WriteLine("----");

        // 02
        foreach(KeyValuePair<int, string> v in veiculos) {
            Console.WriteLine("Chave: {0}, Valor: {1}", v.Key, v.Value);
        }
      
        Console.WriteLine("=========");
        Console.WriteLine("Limpando a tela em 3... 2... 1... ✨");
        Thread.Sleep(3000);
        Console.Clear();
    }
}