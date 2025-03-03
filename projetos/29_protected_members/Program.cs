using System;

class Veiculo { // Classe base
    public int velAtual;
    private int velMax;
    protected bool ligado;

    public Veiculo(int velMax) {
        velAtual = 0;
        this.velMax = velMax;
        ligado = false;
    }

    public int GetVelMax() { 
        return velMax;
    }
}

class Carro : Veiculo { // Classe derivada
    public string nome;

    public Carro(string nome, int vm) : base(vm) {
        this.nome = nome;
        ligado = true;
    }

    public bool getLigado() {
        return ligado;
    }
}

class Program {
    static void Main() {
        Carro carro = new Carro("Bonitão", 120);

        Console.WriteLine("Nome:.........{0}", carro.nome);
        Console.WriteLine("Vel. Máxima:..{0}", carro.GetVelMax());
        Console.WriteLine("Ligado:.......{0}", carro.getLigado());
    }
}
