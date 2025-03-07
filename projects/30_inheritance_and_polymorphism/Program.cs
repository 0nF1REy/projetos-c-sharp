using System;

class Base {
    public Base() {
        Console.WriteLine("Construtor da classe Base");
    }

    virtual public void Info() {
        Console.WriteLine("Base");
    }
}

class Derivada1 : Base {
    public Derivada1() {
        Console.WriteLine("Construtor da classe Derivada 1");
    }

    override public void Info() {
        Console.WriteLine("Derivada 1");
    }
}

class Derivada2 : Derivada1 {
    public Derivada2() {
        Console.WriteLine("Construtor da classe Derivada 2");
    }

    override public void Info() {
        Console.WriteLine("Derivada 2");
    }
}

class Program {
    static void Main() {
        Console.Clear();
        Console.WriteLine("=========================");

        Derivada1 derivada1 = new Derivada1();
        Derivada2 derivada2 = new Derivada2();
        
        Console.WriteLine("-------------------------");

        Base Ref = derivada2;
        derivada1.Info();
        Ref.Info();

        Console.WriteLine("=========================");
    }
}