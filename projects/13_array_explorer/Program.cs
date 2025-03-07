using System;

class Program {
    static void Main() {

        // Declaração de variáveis
        int[] n = new int[5];
        int[] num = new int[3] {55, 77, 99};
        int[] num2 = {55, 77, 99};
        string[] veiculos = new string[3];
        int[,] n2 = new int[3,5];
        int[,] num3 = new int[,] { {10, 20}, {30, 40} }; 

        n[0] = 111;
        n[1] = 222;
        n[2] = 333;
        n[3] = 444;
        n[4] = 555;

        veiculos[0] = "Carro";
        veiculos[1] = "Avião";
        veiculos[2] = "Navio";

        /*
        10 20 30 40 50
        60 70 80 90 15
        25 35 45 55 65
        */

        n2[0,0] = 10; n2[0,1] = 20; n2[0,2] = 30; n2[0,3] = 40; n2[0,4] = 50;
        n2[1,0] = 60; n2[1,1] = 70; n2[1,2] = 80; n2[1,3] = 90; n2[1,4] = 15;
        n2[2,0] = 25; n2[2,1] = 35; n2[2,2] = 45; n2[2,3] = 55; n2[2,4] = 65;

        Console.WriteLine(n[0]);
        Console.WriteLine(num[2]);
        Console.WriteLine(num2[1]);
        Console.WriteLine(veiculos[2]);
        Console.WriteLine(n2[1,3]); // Linha, coluna
        Console.WriteLine(n2[2,1]); // Linha, coluna
    }
}