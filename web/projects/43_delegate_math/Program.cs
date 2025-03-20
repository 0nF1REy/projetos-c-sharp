using System;

delegate int Operacao(int n1, int n2);

class Mat {
    public static int soma(int n1, int n2) {
        return n1 + n2;
    }

    public static int mult(int n1, int n2) {
        return n1 * n2;
    }
}

class Program {
    static void Main() {

        Operacao d1 = new Operacao(Mat.soma);

        int res = d1(10, 50);

        Console.Clear();
        Console.WriteLine("=====");
        Console.WriteLine("Soma: {0}", res);

        d1 = new Operacao(Mat.mult);

        res = d1(10, 50);

        Console.WriteLine("Multiplicação: {0}", res);
        Console.WriteLine("=====");
    }
}
