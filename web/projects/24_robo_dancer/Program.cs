// Programa realizado para estudar sobre classes e objetos !!!
using System;

public class RoboDancer {

    // ==========
    // Variáveis
    // ==========
    public int energia;
    public bool ativo;
    public string estiloDeDanca;
    public string? apelido;

    // =============
    // Construtores
    // =============
    public RoboDancer(string apelido, string estiloDeDanca, bool ativo) {
        this.energia = 100;  
        this.estiloDeDanca = estiloDeDanca;
        this.apelido = apelido;
        this.ativo = ativo;
    }

    public RoboDancer(string apelido, string estiloDeDanca, bool ativo, int energia) {
        this.energia = energia;
        this.estiloDeDanca = estiloDeDanca;
        this.apelido = apelido;
        this.ativo = ativo;
    }

    // ============================
    // Método de execução de dança
    // ============================
    public void Dançar() {
        if (energia <= 0) {
            Console.WriteLine("{0} não tem energia para dançar. Precisa de um recarregamento!", apelido);
        } else {
            Console.WriteLine("{0} está dançando no estilo {1}!", apelido, estiloDeDanca);
            energia -= 10;
        }
    }

    // ============================
    // Método de recarregamento
    // ============================
    public void Recarregar() {
        Console.WriteLine("{0} está se recarregando e ganhando energia de volta!", apelido);
        energia = 100;
    }

    // ============================
    // Método de destruição
    // ============================
    public void Destruir() {
        Console.WriteLine("O robô dançarino {0} foi destruído após a competição!", apelido);
    }

    // ===========
    // Destrutor
    // ===========
    ~RoboDancer() {
        Destruir();
    }
}

class Program {
    static void Main() {

        Console.Clear();
        Console.WriteLine("========================");

        Console.Write("Digite um apelido para seu robô dançarino: ");
        string? apelido = Console.ReadLine();
        Console.WriteLine("========================");

        if (apelido == null) {
            Console.WriteLine("Você não forneceu um apelido! O programa será encerrado.");
            return;
        }

        RoboDancer robo1 = new RoboDancer(apelido, "Break Dance", true, 50); 
        RoboDancer robo2 = new RoboDancer("BoogieBot", "Funk", true);  
        RoboDancer robo3 = new RoboDancer("RoboSoul", "Disco", false); 

        Console.WriteLine("Apelido do robô 01: {0}, Estilo de Dança: {1}, Energia: {2}, Ativo: {3}", robo1.apelido, robo1.estiloDeDanca, robo1.energia, robo1.ativo);
        Console.WriteLine("Apelido do robô 02: {0}, Estilo de Dança: {1}, Energia: {2}, Ativo: {3}", robo2.apelido, robo2.estiloDeDanca, robo2.energia, robo2.ativo);
        Console.WriteLine("Apelido do robô 03: {0}, Estilo de Dança: {1}, Energia: {2}, Ativo: {3}", robo3.apelido, robo3.estiloDeDanca, robo3.energia, robo3.ativo);
        Console.WriteLine("========================");

        robo1.Dançar();
        robo2.Dançar();
        robo3.Dançar();

        robo1.Recarregar();
        robo2.Recarregar();

        robo1.Dançar();
        robo2.Dançar();

        // ======================
        // Removendo referências
        // ======================
        robo1.Destruir();  
        robo1 = null;

        robo2.Destruir();  
        robo2 = null;

        robo3.Destruir();  
        robo3 = null;

        // =============================
        // Forçando o Garbage Collector 
        // =============================
        GC.Collect();
        GC.WaitForPendingFinalizers();

        Console.WriteLine("========================");
        Console.WriteLine("Pressione qualquer tecla para sair.");
        Console.ReadLine();
        Console.WriteLine("========================");
        Console.WriteLine("Fim do programa.");
        Console.WriteLine("========================");
    }
}
