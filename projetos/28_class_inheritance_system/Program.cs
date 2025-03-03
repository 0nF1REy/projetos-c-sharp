using System;

class Traje {
    private int poder;
    public int energiaMax;
    private bool ativado;

    public Traje(int poder) {
        setPoder(poder);
    }

    public void ativar() {
        ativado = true;
    }

    public void desativar() {
        ativado = false;
    }

    public string getAtivado() {
        return ativado ? "Sim" : "Não";
    }

    public int getPoder() {
        return poder;
    }

    public void setPoder(int poder) {
        if (poder < 0) {
            this.poder = 0;
        } else if (poder > 100) {
            this.poder = 100;
        } else {
            this.poder = poder;
        }
    }
}

class TrajeDeCombate : Traje {
    public string nome;
    public string cor;

    public TrajeDeCombate(string nome, string cor) : base(50) {
        desativar();
        setPoder(50); 
        energiaMax = 200;
        this.nome = nome;
        this.cor = cor;
    }
}

class TrajeEspecial : TrajeDeCombate {
    public int poderExtra;

    public TrajeEspecial() : base("Senketsu", "Vermelho e Azul") {
        poderExtra = 100;
        setPoder(100); 
    }
}

class Program {
    static void Main() {
        Console.Clear();
        TrajeDeCombate t1 = new TrajeDeCombate("Kamui", "Preto e Dourado");
        TrajeEspecial te1 = new TrajeEspecial();

        t1.ativar();

        Console.WriteLine("=================================");
        Console.WriteLine("Cor.............. {0}", t1.cor);
        Console.WriteLine("Nome............. {0}", t1.nome);
        Console.WriteLine("Poder............ {0}", t1.getPoder());
        Console.WriteLine("Energia Máxima... {0}", t1.energiaMax);
        Console.WriteLine("Ativado.......... {0}", t1.getAtivado());

        Console.WriteLine("=================================");

        Console.WriteLine("Cor.............. {0}", te1.cor);
        Console.WriteLine("Nome............. {0}", te1.nome);
        Console.WriteLine("Poder............ {0}", te1.getPoder());
        Console.WriteLine("Energia Máxima... {0}", te1.energiaMax);
        Console.WriteLine("Ativado.......... {0}", te1.getAtivado());
        Console.WriteLine("Poder Extra...... {0}", te1.poderExtra);
        Console.WriteLine("=================================");
    }
}
