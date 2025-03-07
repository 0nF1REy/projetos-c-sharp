// Implementação de um sistema utilizando classes abstratas, herança e encapsulamento,
// com demonstração de abstração através de métodos abstratos em programação orientada a objetos.

using System;

// ======================
//  CLASSE BASE ABSTRATA
// ======================
abstract class VeiculoEspacial {
    protected int VelMaxima;
    protected int VelAtual;
    protected bool Ativado;

    public VeiculoEspacial() {
        Ativado = false;
        VelAtual = 0;
    }

    public void SetAtivado(bool ativado) {
        Ativado = ativado;
    }

    public int GetVelAtual() {
        return VelAtual;
    }

    public abstract void Impulsionar(int fator);
}

// =================
//  CLASSE DERIVADA
// =================
class Nave : VeiculoEspacial {
    public Nave() {
        VelMaxima = 12000; 
    }

    public override void Impulsionar(int fator) {
        VelAtual += 1000 * fator; 
    }
}

// ====================
//  PROGRAMA PRINCIPAL
// ====================
class Program {
    static void Main() {
        Console.Clear();
        Console.WriteLine("===========================");

        Nave nave1 = new Nave();

        nave1.Impulsionar(2);
        nave1.Impulsionar(-1);

        Console.WriteLine($"Velocidade atual: {nave1.GetVelAtual()} km/h");

        Console.WriteLine("===========================");
    }
}