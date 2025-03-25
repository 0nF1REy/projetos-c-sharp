using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("=========");
        
        List<string> magias = new List<string> {
            "Raio",
            "Cura",
            "Fogo",
            "Escudo",
            "Cura"
        };

        string[] magiasArray = new string[magias.Count];
        magias.CopyTo(magiasArray, 0);

        VerificarMagiaNaLista(magias, "Vento");

        Console.WriteLine("----");

        magias.Insert(1, "Gelo");
        RemoverMagia(magias, "Escudo");

        magiasArray = new string[magias.Count];
        magias.CopyTo(magiasArray, 0);

        int posUltimaCura = magias.LastIndexOf("Cura");

        magias.Sort();

        int tamanho = magias.Count;
        magias.Capacity = 13;
        int capacidade = magias.Capacity;

        Console.WriteLine("Número de magias no grimório: {0}", tamanho);
        Console.WriteLine("Capacidade do grimório: {0}", capacidade);
        Console.WriteLine("----");

        ExibirMagias(magiasArray);

        Console.WriteLine("----");

        ExibirPosicaoMagia(magias, "Cura", posUltimaCura);

        Console.WriteLine("=========");
        Console.WriteLine("Limpando a tela em 3... 2... 1... ✨");
        Thread.Sleep(3000);
        Console.Clear();
    }

    static void VerificarMagiaNaLista(List<string> magias, string magiaBusca)
    {
        if (magias.Contains(magiaBusca))
        {
            Console.WriteLine($"A magia {magiaBusca} está no grimório!");
        }
        else
        {
            Console.WriteLine($"A magia {magiaBusca} não foi encontrada no grimório.");
        }
    }

    static void RemoverMagia(List<string> magias, string magia)
    {
        if (magias.Remove(magia))
        {
            Console.WriteLine($"A magia {magia} foi removida.");
        }
        else
        {
            Console.WriteLine($"Não foi possível remover a magia {magia}.");
        }

        Console.WriteLine("----");
    }

    static void ExibirMagias(string[] magias)
    {
        foreach (string magia in magias)
        {
            Console.WriteLine($"Magia: {magia}");
        }
    }

    static void ExibirPosicaoMagia(List<string> magias, string magiaBusca, int posUltima)
    {
        int pos = magias.IndexOf(magiaBusca);
        Console.WriteLine($"A magia {magiaBusca} está na posição {pos} no grimório.");
        Console.WriteLine($"A última magia {magiaBusca} está na posição {posUltima}.");
    }
}
