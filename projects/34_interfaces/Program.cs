using System;

public interface Guerreiro {
    void preparar();
    void descansar();
    void status();
}

public interface Arqueiro {
    void dispararFlecha();
}

class ArqueiroDeElite : Guerreiro, Arqueiro {
    public bool pronto;
    private int flechas;

    public ArqueiroDeElite() {
        setFlechas(30);
        Console.WriteLine("Arqueiro de elite recrutado!");
    }

    public void setFlechas(int qtde) {
        this.flechas = qtde;
    }

    public void preparar() {
        this.pronto = true;
        Console.WriteLine("O arqueiro está preparado para a batalha.");
    }

    public void descansar() {
        this.pronto = false;
        Console.WriteLine("O arqueiro descansou e guardou seu arco.");
    }

    public void dispararFlecha() {
        if (flechas > 0) {
            Console.WriteLine("O arqueiro dispara uma flecha certeira!");
            flechas--;
        } else {
            Console.WriteLine("Sem flechas restantes!");
        }
    }

    public void status() {
        Console.WriteLine($"O arqueiro está { (pronto ? "pronto" : "descansando") } e tem {flechas} flechas restantes.");
    }
}

class Program {
    static void Main() {

        Console.Clear();
        Console.WriteLine("=============================");

        ArqueiroDeElite arqueiro = new ArqueiroDeElite();
        arqueiro.status();

        Console.WriteLine("=============================");
    }
}
