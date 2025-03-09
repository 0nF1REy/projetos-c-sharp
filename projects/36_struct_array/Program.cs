using System;

struct DispositivoArmazenamento {
    public string nome;
    public string capacidade;

    public void Info() {
        Console.WriteLine("Dispositivo....{0}", this.nome);
        Console.WriteLine("Capacidade.....{0}", this.capacidade);
        Console.WriteLine("-------------------------");
    }
}

class Program {
    static void Main() {

        DispositivoArmazenamento[] dispositivos = new DispositivoArmazenamento[4];

        dispositivos[0].nome = "HD Externo";
        dispositivos[0].capacidade = "1TB";

        dispositivos[1].nome = "SSD Interno";
        dispositivos[1].capacidade = "500GB";

        dispositivos[2].nome = "Pendrive";
        dispositivos[2].capacidade = "32GB";

        dispositivos[3].nome = "Cartão de Memória";
        dispositivos[3].capacidade = "128GB";

        Console.Clear();
        Console.WriteLine("-------------------------");

        for(int i = 0; i < dispositivos.Length; i++) {
            dispositivos[i].Info();
        }

        Console.WriteLine(" ");
    }
}
