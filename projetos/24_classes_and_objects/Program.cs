using System;

public class Dragao {
    public int força = 100;
    public bool vivo = true;
}

class Program {
    static void Main() {

        Dragao dragao1 = new Dragao();
        Dragao dragao2 = new Dragao();
        Dragao dragao3 = new Dragao();

        Console.Clear();
        dragao1.força = 50;
        Console.WriteLine("Força do dragão 1: {0}", dragao1.força);
        Console.WriteLine("Força do dragão 2: {0}", dragao2.força);
    }
}
