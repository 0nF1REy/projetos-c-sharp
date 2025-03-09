using System;

class ServidorDeRede {
    private string nomeServidor;
    private int numConexao;

    public ServidorDeRede(string nomeServidor) {
        this.nomeServidor = nomeServidor;
        numConexao = 0;
    }

    public ConexaoDeRede aceitarConexao() {
        numConexao++;
        return new ConexaoDeRede(numConexao, nomeServidor);
    }
}

class ConexaoDeRede {
    private int idConexao;
    private string servidorResponsavel;

    public ConexaoDeRede(int idConexao, string servidorResponsavel) {
        this.idConexao = idConexao;
        this.servidorResponsavel = servidorResponsavel;
        Console.WriteLine("Conexão criada: {0} - {1}", this.idConexao, this.servidorResponsavel);
    }
}

class Program {
    static void Main() {
        ServidorDeRede s1 = new ServidorDeRede("Servidor_Principal");
        ServidorDeRede s2 = new ServidorDeRede("Servidor_2");
        ServidorDeRede s3 = new ServidorDeRede("Servidor_Backup");

        Console.Clear();

        Console.WriteLine("-------------------------");
        s1.aceitarConexao();
        s1.aceitarConexao();
        s1.aceitarConexao();
        Console.WriteLine("-------------------------");
        s2.aceitarConexao();
        Console.WriteLine("-------------------------");
        s3.aceitarConexao();
        s3.aceitarConexao();
        Console.WriteLine("-------------------------\n");
    }
}
