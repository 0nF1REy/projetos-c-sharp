using System;

class Program {
    static void Main() {

        Console.Clear();
        Console.WriteLine("========================");
        for (int i = 0; i < 2; i++) {
            Console.WriteLine("-----PERSONAGENS--------");
            PERSONAGENS();
            Console.WriteLine("---------SOMA----------");
            SOMA(10, 5);
        }
        Console.WriteLine("=======================");
    }

    static void PERSONAGENS() {
        Console.WriteLine("Aerith Gainsborough");
        Console.WriteLine("Tifa Lockhart");
        Console.WriteLine("Cloud Strife");
    }

    static void SOMA(int n1, int n2) {
        int res = n1 + n2;
        Console.WriteLine("A soma de {0} e {1} é: {2}", n1, n2, res);
    }
}
