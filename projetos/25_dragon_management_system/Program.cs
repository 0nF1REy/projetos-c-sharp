using System;

public class Dragao {
    // ==========
    // Variáveis
    // ==========
    public int forca;
    public bool vivo;
    public string elemento;
    public string? apelido;

    // ===========================
    // Sobrecarga de Construtores
    // ===========================
    public Dragao(string apelido, string elemento, int forca, bool vivo) {
        this.forca = forca;
        this.vivo = vivo;
        this.elemento = elemento;
        this.apelido = apelido;
    }

    public Dragao() {
        this.forca = 100;
        this.vivo = true;
        this.elemento = "Fogo";
        this.apelido = "natsu";
    }

    // ============================
    // Método para alterar a força
    // ============================
    public void AlterarForca(int novaForca) {
        this.forca = novaForca;
    }

    public void info() {
        Console.WriteLine("Nome do dragão:.....{0}", apelido);
        Console.WriteLine("Elemento do dragão:.{0}", elemento);
        Console.WriteLine("Força do dragão:....{0}", forca);
        Console.WriteLine("Estado do dragão:...{0}\n", vivo);
    }

    // ============================
    // Método de limpeza explícita
    // ============================
    public void Destruir() {
        Console.WriteLine("Destruidor chamado! O dragão {0} foi destruído!", apelido);
    }

    // ===========
    // Destrutor
    // ===========
    ~Dragao() {
        Destruir();
    }
}

class Program {
    static void Main() {
        Console.Clear();
        Console.WriteLine("========================");

        // Entrada para apelido
        Console.Write("Digite um apelido para seu dragão 1: ");
        string? apelido = Console.ReadLine();
        Console.WriteLine("========================");

        // Verifica se o apelido foi informado
        if (apelido == null) {
            Console.WriteLine("Você não forneceu um apelido! O programa será encerrado.");
            return;
        }

        // Entrada para o elemento
        Console.Write("Digite o elemento do dragão (Fogo, Gelo, etc.): ");
        string elemento = Console.ReadLine() ?? "Fogo";

        // Entrada para a força
        Console.Write("Digite a força do dragão (valor numérico): ");
        int forca;
        while (!int.TryParse(Console.ReadLine(), out forca)) {
            Console.WriteLine("Valor inválido! Digite um número inteiro para a força.");
        }

        // Entrada para o estado de vida
        Console.Write("O dragão está vivo? (true/false): ");
        bool vivo;
        while (!bool.TryParse(Console.ReadLine(), out vivo)) {
            Console.WriteLine("Valor inválido! Digite 'true' ou 'false' para o estado de vida.");
        }

        // Criação do dragão com as informações fornecidas
        Dragao dragao1 = new Dragao(apelido, elemento, forca, vivo);
        Dragao dragao2 = new Dragao();
        Dragao dragao3 = new Dragao("SemNome", "Gelo", 120, true);
        Dragao dragao4 = new Dragao("Siegfried", "Ar", 90, false);

        // =======================
        // Altera: força - dragão
        // =======================
        dragao1.AlterarForca(50);
        dragao2.AlterarForca(80);
        dragao3.AlterarForca(120);

        // Exibe as informações dos dragões
        dragao1.info();
        dragao2.info();
        dragao3.info();
        dragao4.info();

        // ======================
        // Removendo referências e chamando Destruir explicitamente
        // ======================
        dragao1.Destruir();
        dragao1 = null;

        dragao2.Destruir();
        dragao2 = null;

        dragao3.Destruir();
        dragao3 = null;

        dragao4.Destruir();
        dragao4 = null;

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
