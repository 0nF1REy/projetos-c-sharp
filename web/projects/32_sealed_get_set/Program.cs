using System;

sealed class TanqueAgua { // sealed: Não permite herança
    private int capacidadeMax;

    public int Capacidade {
        get {
            return capacidadeMax;
        }
        set {
            if (value < 0) {
                capacidadeMax = 0;
            }
            else if (value > 1000) { 
                capacidadeMax = 1000;
            } else {
                capacidadeMax = value;
            }
        }
    }

    public TanqueAgua() {
        Capacidade = 500; 
    }
}

class Program {
    static void Main() {

        Console.Clear();
        Console.WriteLine("================================");

        TanqueAgua tanque = new TanqueAgua();

        tanque.Capacidade = 800; 

        Console.WriteLine("Capacidade do tanque: {0} litros", tanque.Capacidade);
        Console.WriteLine("================================");
    }
}
