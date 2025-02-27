using System;

class Program {
    static void Main() {
        // Variáveis
        int num = 50;
        int num2 = 50;

        Console.Clear();

        DOBRAR(ref num); 
        Console.WriteLine(num);
        DOBRAR2(num2);
        Console.WriteLine(num2);
    }
    static void DOBRAR(ref int valor) {
        valor *= 2;
    }

    static void DOBRAR2(int valor) {
        valor *= 2;
    }
}